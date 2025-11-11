using OptimizerTestTool.Services;
using Shared.Models.Train;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TrainCharacteristicsManager;
using TrainCharacteristicsManager.Models;


namespace OptimizerTestTool.Pages;

public partial class ConsistBuilderPage : ContentPage
{
    private TrainCharacteristicsBuilder _trainCharacteristicsBuilder;
    private TrainCharacteristicsBuilderProvider _trainCharacteristicsBuilderProvider;
    private Dictionary<string, TrainUnitParameters> _trainParameters;
    private List<TrainUnit> _trainUnits;
    private int _emptyCount;
    private TrainCharacteristicsSimple _trainCharacteristics;
    private CalculationRepository _calcRepo;
    private bool _isConsistConfirmed = false;

    public ConsistBuilderPage(CalculationRepository calcRepo, TrainCharacteristicsBuilderProvider trainCharacteristicsBuilderProvider)
    {
        InitializeComponent();
        CalcRepo = calcRepo;
        _trainCharacteristicsBuilderProvider = trainCharacteristicsBuilderProvider;
        _emptyCount = ((VerticalStackLayout)Content).Children.Count;
        _trainUnits = new List<TrainUnit>();

        var confirmButton = new Button
        {
            Text = "Confirm Final Consist"
        };
        confirmButton.Clicked += ConfirmBtn_Clicked;
        ((VerticalStackLayout)Content).Children.Add(confirmButton);
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        _trainCharacteristicsBuilder = await _trainCharacteristicsBuilderProvider.GetBuilderAsync();
        InitializeTrainParameters();
    }

    public CalculationRepository CalcRepo { get; set; }

    private void AddBtn_Clicked(object sender, EventArgs e)
    {
        if (TrainTypePicker.SelectedItem == null)
        {
            DisplayAlert("Error", "Please select a train type.", "OK");
            return;
        }

        var selectedTrainType = TrainTypePicker.SelectedItem.ToString();
        var tp = _trainParameters[selectedTrainType];
        var baseType = tp.BaseClassType;

        var stackLayout = new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Children =
                {
                    new Label { Text = selectedTrainType, WidthRequest = 250 },
                    new Entry { Text = tp.Mass.ToString(), WidthRequest = 100 },
                    new Entry { Text = "100", WidthRequest = 100 },
                    new Entry { Text = "195", WidthRequest = 100 },
                    new Button { Text = "Remove", Command = new Command(RemoveEntry), CommandParameter = selectedTrainType }
                }
        };
        var filteredTypes = _trainParameters
        .Where(x => x.Value.BaseClassType == baseType)
        .ToDictionary(x => x.Key, x => x.Value);

        TrainTypePicker.SelectedIndex = 0; 

        TrainTypePicker.ItemsSource = new ObservableCollection<string>(filteredTypes.Keys);

        ((VerticalStackLayout)Content).Children.Add(stackLayout);

        UpdateTrainCharacteristics();
    }

    private void RemoveEntry(object parameter)
    {
        var stackLayout = ((VerticalStackLayout)Content).Children
            .FirstOrDefault(c => c is StackLayout layout && layout.Children.OfType<Label>().Any(l => l.Text == parameter.ToString()));

        if (stackLayout != null)
        {
            ((VerticalStackLayout)Content).Children.Remove(stackLayout);
            if (((VerticalStackLayout)Content).Children.Count == _emptyCount)
                InitializeTrainParameters();
        }

        UpdateTrainCharacteristics();
    }

    private async void InitializeTrainParameters()
    {
        _trainParameters = _trainCharacteristicsBuilder.TrainParameters;
        TrainTypePicker.ItemsSource = new ObservableCollection<string>(_trainParameters.Keys);
        TrainTypePicker.SelectedIndex = 0;
    }
    private void UpdateTrainCharacteristics()
    {
        _trainUnits = GetTrainUnitsFromUI();
        if (_trainUnits != null && _trainUnits.Any())
        {
            var trainCharacteristics = _trainCharacteristicsBuilder.Build(_trainUnits);
            ValidateTrainCharacteristics(trainCharacteristics);
            CalcRepo.TrainCharacteristics = trainCharacteristics;
        }
    }

    private void ValidateTrainCharacteristics(TrainCharacteristicsSimple trainCharacteristics)
    {
        if (trainCharacteristics == null)
        {
            DisplayAlert("Error", "No valid train consist.", "OK");
            return;
        }
    }
   

    // Button click handler
    private void ConfirmBtn_Clicked(object sender, EventArgs e)
    {
        UpdateTrainCharacteristics();
        _isConsistConfirmed = true;
        DisplayAlert("Confirmed", "Train consist confirmed.", "OK");
    }

    // Override OnDisappearing to build if not confirmed
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (!_isConsistConfirmed)
        {
            UpdateTrainCharacteristics();
        }
    }
    private List<TrainUnit> GetTrainUnitsFromUI()
    {
        var trainUnits = new List<TrainUnit>();
        foreach (var child in ((VerticalStackLayout)Content).Children)
        {
            if (child is StackLayout layout && layout.Children.Count >= 4)
            {
                var label = layout.Children[0] as Label;
                var massEntry = layout.Children[1] as Entry;
                var tractionEntry = layout.Children[2] as Entry;
                var brakeEntry = layout.Children[3] as Entry;

                if (label != null && massEntry != null && tractionEntry != null && brakeEntry != null)
                {
                    var trainUnit = new TrainUnit
                    {
                        Class = label.Text,
                        TotalMass = float.TryParse(massEntry.Text, out var mass) ? mass : 0,
                        TractionPercentage = float.TryParse(tractionEntry.Text, out var traction) ? traction : 0,
                        BrakeWeightPercentage = float.TryParse(brakeEntry.Text, out var brake) ? brake : 0
                    };
                    trainUnits.Add(trainUnit);
                }
            }
        }
        return trainUnits;
    }
}