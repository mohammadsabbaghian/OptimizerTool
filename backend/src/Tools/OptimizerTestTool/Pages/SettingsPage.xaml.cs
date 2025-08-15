using OptimizerTestTool.Services;
using Shared.Models;
using System.Text.Json;

namespace OptimizerTestTool;

public partial class SettingsPage : ContentPage
{
    private CalculationRepository _calcRepo;

    public CalculationRepository CalcRepo
    {
        get
        {
            return _calcRepo;
        }
        set
        {
            _calcRepo = value;
        }
    }

    public SettingsPage(CalculationRepository calcRepo)
    {
        InitializeComponent();
        CalcRepo = calcRepo;
        LoadOrDefaultSettings();
        PopulateFieldsWithDefaults();
    }
    private void LoadOrDefaultSettings()
    {
        var settingsPath = Path.Combine(FileSystem.AppDataDirectory, "Projects", "settings.json");
        if (File.Exists(settingsPath))
        {
            var json = File.ReadAllText(settingsPath);
            var loadedConfig = JsonSerializer.Deserialize<AlgorithmConfiguration>(json);
            if (loadedConfig != null)
                _calcRepo.AlgorithmConfiguration = loadedConfig;
        }
        else
        {
            _calcRepo.AlgorithmConfiguration = new AlgorithmConfiguration();
        }
    }
    private void PopulateFieldsWithDefaults()
    {
        SpeedDiscretizationEntry.Text = _calcRepo.AlgorithmConfiguration.SpeedDiscretization.ToString();
        MinimumSpeedAdviceEntry.Text = _calcRepo.AlgorithmConfiguration.MinimumSpeedAdvice.ToString();
        JerkLimitationEntry.Text = _calcRepo.AlgorithmConfiguration.JerkLimitation.ToString();
        MinCoastingDistanceEntry.Text = _calcRepo.AlgorithmConfiguration.MinCoastingDistance.ToString();
        CoastingStepDistanceEntry.Text = _calcRepo.AlgorithmConfiguration.CoastingStepDistance.ToString();
        FinalAdviceThresholdEntry.Text = _calcRepo.AlgorithmConfiguration.FinalAdviceThreshold.ToString();
        MinTimeTillFirstTimingPointEntry.Text = _calcRepo.AlgorithmConfiguration.MinTimeTillFirstTimingPoint.ToString();
        BrakingTimeToleranceEntry.Text = _calcRepo.AlgorithmConfiguration.BrakingTimeTolerance.ToString();
        MinimumPeakTimeEntry.Text = _calcRepo.AlgorithmConfiguration.MinimumPeakTime.ToString();
        ReactionTimeEntry.Text = _calcRepo.AlgorithmConfiguration.ReactionTime.ToString();
        CalculationTimeToleranceEntry.Text = _calcRepo.AlgorithmConfiguration.CalculationTimeTolerance.ToString();
        MaxCalculationTimeEntry.Text = _calcRepo.AlgorithmConfiguration.MaxCalculationTime.ToString();
        FinalArrivalMandatorySwitch.IsToggled = _calcRepo.AlgorithmConfiguration.FinalArrivalMandatory;
        AllowBrakingAdviceSwitch.IsToggled = _calcRepo.AlgorithmConfiguration.AllowBrakingAdvice;
        MinimumCoastingSpeedEntry.Text = _calcRepo.AlgorithmConfiguration.MinimumCoastingSpeed.ToString();
    }

    private void SpeedDiscretizationEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (float.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.SpeedDiscretization = value;
    }

    private void MinimumSpeedAdviceEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (float.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.MinimumSpeedAdvice = value;
    }

    private void JerkLimitationEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (float.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.JerkLimitation = value;
    }

    private void MinCoastingDistanceEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (double.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.MinCoastingDistance = value;
    }

    private void CoastingStepDistanceEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (double.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.CoastingStepDistance = value;
    }

    private void FinalAdviceThresholdEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (int.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.FinalAdviceThreshold = value;
    }

    private void MinTimeTillFirstTimingPointEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (double.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.MinTimeTillFirstTimingPoint = value;
    }

    private void BrakingTimeToleranceEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (int.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.BrakingTimeTolerance = value;
    }

    private void MinimumPeakTimeEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (int.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.MinimumPeakTime = value;
    }

    private void ReactionTimeEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (int.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.ReactionTime = value;
    }

    private void CalculationTimeToleranceEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (int.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.CalculationTimeTolerance = value;
    }

    private void MaxCalculationTimeEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (int.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.MaxCalculationTime = value;
    }

    private void FinalArrivalMandatorySwitch_Toggled(object sender, ToggledEventArgs e)
    {
        _calcRepo.AlgorithmConfiguration.FinalArrivalMandatory = e.Value;
    }

    private void AllowBrakingAdviceSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        _calcRepo.AlgorithmConfiguration.AllowBrakingAdvice = e.Value;
    }

    private void MinimumCoastingSpeedEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (float.TryParse(e.NewTextValue, out var value))
            _calcRepo.AlgorithmConfiguration.MinimumCoastingSpeed = value;
    }

    private async void OnSaveSettingsClicked(object sender, EventArgs e)
    {
        var settingsPath = Path.Combine(FileSystem.AppDataDirectory, "Projects", "settings.json");
        var json = JsonSerializer.Serialize(_calcRepo.AlgorithmConfiguration);
        await File.WriteAllTextAsync(settingsPath, json);
        await DisplayAlert("Settings", "Settings saved successfully.", "OK");
    }
}