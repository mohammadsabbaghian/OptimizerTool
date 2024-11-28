using SpeedOptimizer.Models.Inputs;
using System.Collections.ObjectModel;
using TrainCharacteristicsManager;

namespace OptimizerTestTool.Pages;

public partial class ConsistBuilderPage : ContentPage
{
    private TrainCharacteristicsBuilder _trainCharacteristicsBuilder;

    private Dictionary<string, TrainUnitParametersSimple> _trainParameters;
    private List<TrainUnit> _trainUnits;
    private int _emptyCount;

    public ConsistBuilderPage()
    {
        InitializeComponent();
        InitializeTrainParameters();
        _emptyCount = (this.Content as VerticalStackLayout).Children.Count;
    }

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

        (this.Content as VerticalStackLayout).Children.Add(stackLayout);
    }

    private void RemoveEntry(object parameter)
    {
        var stackLayout = (this.Content as VerticalStackLayout).Children
            .FirstOrDefault(c => c is StackLayout layout && layout.Children.OfType<Label>().Any(l => l.Text == parameter.ToString()));

        if (stackLayout != null)
        {
            (this.Content as VerticalStackLayout).Children.Remove(stackLayout);
            if ((this.Content as VerticalStackLayout).Children.Count == _emptyCount)
                InitializeTrainParameters();
        }
    }

    private void ConfirmBtn_Clicked(object sender, EventArgs e)
    {
        // Handle confirm button click
        _trainCharacteristicsBuilder.Build(_trainUnits);
    }

    private void TrainTypePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Handle picker selection change
    }

    private async void InitializeTrainParameters()
    {
        if(_trainParameters == null)
            _trainParameters = await TrainUnitParametersRepository.GetTrainUnitParametersAsync();
        TrainTypePicker.ItemsSource = new ObservableCollection<string>(_trainParameters.Keys);
        TrainTypePicker.SelectedIndex = 0;
        _trainCharacteristicsBuilder = new TrainCharacteristicsBuilder(_trainParameters);
    }
}