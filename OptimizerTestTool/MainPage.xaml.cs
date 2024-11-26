using System.Collections.ObjectModel;
using TrainCharacteristicsManager;
using SpeedOptimizer.Models.Inputs;


namespace OptimizerTestTool
{
    public partial class MainPage : ContentPage
    {
        private TrainCharacteristicsBuilder _trainCharacteristicsBuilder;
        
        private Dictionary<string, TrainParameters> _trainParameters;

        public MainPage()
        {
            InitializeComponent();
            InitializeTrainParameters();
        }

        private void OnLoadClicked(object sender, EventArgs e)
        {
            SemanticScreenReader.Announce(LoaderBtn.Text);
        }

        private async void InitializeTrainParameters()
        {
            _trainCharacteristicsBuilder = new TrainCharacteristicsBuilder();
            _trainParameters = await TrainCharacteristicsRepository.GetTrainParametersAsync();
            TrainTypePicker.ItemsSource = new ObservableCollection<string>(_trainParameters.Keys);
            TrainTypePicker.SelectedIndex = 0;
        }

        private void TrainTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}