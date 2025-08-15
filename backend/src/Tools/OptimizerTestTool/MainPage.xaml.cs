using OptimizerTestTool.Services;
using Shared.Models.Route;
using Shared.Models.Timetable;
using TrainCharacteristicsManager;
using Resources;

namespace OptimizerTestTool
{
    public partial class MainPage : ContentPage
    {
        private ProjectRepository _projectRepository;
        private TimeConstraints _timeConstraints;
        private RouteConstraints _routeConstraints;
        private string _jpFilePath;
        private string _spFilePath;
        private OptimizerProject _project;

        public CalculationRepository CalcRepository { get; }

        private ISferaMessage _jpMessage;
        private ISferaMessage _spMessage;
        private string _jpVersion;
        private bool _jpHasSp;
        private TrainCharacteristicsBuilderProvider _trainCharacteristicsBuilderProvider;
        private TrainCharacteristicsBuilder _trainCharacteristicsBuilder;

        public MainPage(CalculationRepository calcRepository, TrainCharacteristicsBuilderProvider trainCharacteristicsBuilderProvider)
        {
            InitializeComponent();
            _projectRepository = new ProjectRepository();
            _trainCharacteristicsBuilderProvider = trainCharacteristicsBuilderProvider;
            LoadInitialDataAsync();
            CalcRepository = calcRepository;
            UpdateUIStatus();

            //xmlMapper.GetTrainUnitParametersAsync();
        }

        private async void LoadInitialDataAsync()
        {
            try
            {
                _trainCharacteristicsBuilder = await _trainCharacteristicsBuilderProvider.GetBuilderAsync();
                LoadingLabel.Text = "Loading projects...";
                await LoadProjectListAsync();

                LoadingLabel.IsVisible = false;
                StatusLabel.Text = "Ready.";
            }
            catch (Exception ex)
            {
                LoadingLabel.Text = $"Error loading data: {ex.Message}";
                StatusLabel.Text = LoadingLabel.Text;
            }
        }

        private async Task TryMapProfilesAsync()
        {
            if (CalcRepository.TrainCharacteristics == null)
                CalcRepository.TrainCharacteristics = _trainCharacteristicsBuilder.GetDefaultTrainCharacteristics();

            if (_jpMessage != null && (_spMessage != null || _jpHasSp))
            {
                try
                {
                    var handler = SferaMessageHandlerFactory.GetHandler(_jpVersion);
                    (_timeConstraints, _routeConstraints) = handler.MapProfiles(_jpMessage, _spMessage, CalcRepository.TrainCharacteristics);

                    _project = new OptimizerProject
                    {
                        TrainNumber = _timeConstraints.TrainNumber,
                        JourneyProfile = _jpMessage,
                        SferaVersion = _jpVersion,
                        SegmentProfiles = _spMessage,
                        AlgorithmConfiguration = CalcRepository.AlgorithmConfiguration,
                        TrainCharacteristics = CalcRepository.TrainCharacteristics
                    };

                    CalcRepository.TimeConstraints = _timeConstraints;
                    CalcRepository.RouteConstraints = _routeConstraints;

                    CalcRepository.TrainCharacteristics = _trainCharacteristicsBuilder.GetDefaultTrainCharacteristics();

                    StatusLabel.Text = "Mapping successful. You are all set!";
                    SaveProjectButton.IsEnabled = true;
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = $"Error mapping profiles: {ex.Message}";
                    SaveProjectButton.IsEnabled = false;
                }
            }
            else
            {
                StatusLabel.Text = "Waiting for both JP and SP files.";
                SaveProjectButton.IsEnabled = false;
            }
            UpdateUIStatus();
        }

        private (ISferaMessage, string, bool) DeserializeFile(string filePath, string fileType)
        {
            var (message, rootElement, version, containsSegmentProfile) = XmlParser.DeserializeXmlFile(filePath);

            if (message == null)
                throw new InvalidOperationException($"Failed to deserialize {fileType} file.");
            return (message, version, containsSegmentProfile);
        }

        // This method should extract SP from JP if present
        private ISferaMessage DeserializeSPFromJP(string jpFilePath)
        {
            // If your JP file includes SP, extract it here.
            // For now, just return the JP message as SP (adjust as needed for your domain).
            var (spMessage, _, _) = DeserializeFile(jpFilePath, "SP");
            return spMessage;
        }

        private async void OnSaveProjectClicked(object sender, EventArgs e)
        {
            if (_project == null)
            {
                StatusLabel.Text = "No project to save.";
                return;
            }

            var now = DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
            var tc = _project.TrainCharacteristics as ITrainCharacteristics;
            var defaultName = $"{now}_{_project.TrainNumber}_{tc.TrainUnits.First().Class}";

            string projectName = await DisplayPromptAsync(
                "Save Project",
                "Enter a name for your project:",
                initialValue: defaultName,
                maxLength: 64,
                keyboard: Keyboard.Text
            );

            if (string.IsNullOrWhiteSpace(projectName))
            {
                StatusLabel.Text = "Project name cannot be empty.";
                return;
            }

            _project.Name = projectName;
            _project.AlgorithmConfiguration = CalcRepository.AlgorithmConfiguration;
            _project.TrainCharacteristics = CalcRepository.TrainCharacteristics;
            _project.SavedAt = DateTime.Now;
            try
            {
                await _projectRepository.SaveProjectAsync(_project);

            }
            catch (Exception ex)
            {
            }
            StatusLabel.Text = $"Project '{_project.Name}' saved successfully.";
            LoadProjectListAsync();
        }

        private void UpdateUIStatus()
        {
            SaveProjectButton.IsEnabled = (_timeConstraints != null && _routeConstraints != null);
        }

        private async Task LoadProjectListAsync()
        {
            await Task.Yield();
            var projects = _projectRepository.ListProjects().ToList();
            ProjectListView.ItemsSource = projects;
        }


        private async void OnProjectSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is string projectName)
            {
                try
                {
                    LoadingLabel.Text = $"Loading project '{projectName}'...";
                    LoadingLabel.IsVisible = true;

                    var project = await _projectRepository.LoadProjectAsync(projectName);

                    var handler = SferaMessageHandlerFactory.GetHandler(project.SferaVersion);
                    var (timeConstraints, routeConstraints) = handler.MapProfiles(
                        project.JourneyProfile as ISferaMessage,
                        project.SegmentProfiles as ISferaMessage,
                        project.TrainCharacteristics as TrainCharacteristicsSimple
                    );

                    CalcRepository.TimeConstraints = timeConstraints;
                    CalcRepository.RouteConstraints = routeConstraints;
                    CalcRepository.TrainCharacteristics = project.TrainCharacteristics as TrainCharacteristicsSimple;
                    CalcRepository.AlgorithmConfiguration = project.AlgorithmConfiguration;

                    StatusLabel.Text = $"Project '{projectName}' loaded.";
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = $"Error loading project: {ex.Message}";
                }
                finally
                {
                    LoadingLabel.IsVisible = false;
                }
            }
        }
        private async void OnDeleteProjectClicked(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.CommandParameter is string projectName)
            {
                bool confirm = await DisplayAlert("Delete Project",
                    $"Are you sure you want to delete '{projectName}'?", "Delete", "Cancel");
                if (confirm)
                {
                    try
                    {
                        _projectRepository.DeleteProjectFile(projectName); 
                        await LoadProjectListAsync();   
                        StatusLabel.Text = $"Project '{projectName}' deleted."; 
                    }
                    catch (Exception ex)
                    {
                        StatusLabel.Text = $"Error deleting project: {ex.Message}";
                    }
                }
            }
        }

        private async void OnLoadProfileClicked(object sender, EventArgs e)
        {
            var result = await FilePicker.PickAsync(new PickOptions { PickerTitle = "Select Profile File" });
            if (result != null && result.FileName.EndsWith(".xml"))
            {
                var filePath = result.FullPath;
                ProfileStatusLabel.Text = $"Profile: {result.FileName}";
                ProfileCheckmark.IsVisible = true;

                // Try to load both profiles from the file
                var (jpMessage, spMessage, version) = TryLoadProfiles(filePath);

                if (jpMessage != null && spMessage != null)
                {
                    // Both profiles present, proceed
                    _jpMessage = jpMessage;
                    _spMessage = spMessage;
                    _jpVersion = version;
                    await TryMapProfilesAsync();
                }
                else if (jpMessage != null)
                {
                    // Only JP present, prompt for SP
                    _jpMessage = jpMessage;
                    _jpVersion = version;
                    ProfileStatusLabel.Text = "JP loaded. Please select SP file.";
                    await PromptForMissingProfile("SP");
                }
                else if (spMessage != null)
                {
                    // Only SP present, prompt for JP
                    _spMessage = spMessage;
                    ProfileStatusLabel.Text = "SP loaded. Please select JP file.";
                    await PromptForMissingProfile("JP");
                }
                else
                {
                    ProfileStatusLabel.Text = "Invalid profile file.";
                    ProfileCheckmark.IsVisible = false;
                }
            }
            else
            {
                ProfileStatusLabel.Text = "Profile: Invalid file";
                ProfileCheckmark.IsVisible = false;
            }
            UpdateUIStatus();
        }

        private (ISferaMessage jpMessage, ISferaMessage spMessage, string version) TryLoadProfiles(string filePath)
        {
            // Attempt to deserialize the file as JP
            var (jpMessage, rootElement, version, containsSegmentProfile) = XmlParser.DeserializeXmlFile(filePath);

            ISferaMessage spMessage = null;

            // If JP contains SP, extract it
            if (containsSegmentProfile)
            {
                spMessage = DeserializeSPFromJP(filePath);
            }
            else
            {
                // Try to load as SP if JP is not present
                var (spCandidate, _, spVersion, _) = XmlParser.DeserializeXmlFile(filePath);
                // You may need to add logic to distinguish JP and SP messages if both can be present
                if (spCandidate != null && jpMessage == null)
                {
                    spMessage = spCandidate;
                    version = spVersion;
                }
            }

            // Return both messages if found, or whichever is present
            return (jpMessage, spMessage, version);
        }

        private async Task PromptForMissingProfile(string missingType)
        {
            var result = await FilePicker.PickAsync(new PickOptions { PickerTitle = $"Select {missingType} File" });
            if (result != null && result.FileName.EndsWith(".xml"))
            {
                var filePath = result.FullPath;
                var (message, version, _) = DeserializeFile(filePath, missingType);
                if (missingType == "JP")
                {
                    _jpMessage = message;
                    _jpVersion = version;
                }
                else
                {
                    _spMessage = message;
                }
                await TryMapProfilesAsync();
            }
            else
            {
                ProfileStatusLabel.Text = $"{missingType}: Invalid file";
                ProfileCheckmark.IsVisible = false;
            }
            UpdateUIStatus();
        }
    }
}