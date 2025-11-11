using OptimizerTestTool.Services;
using Shared.Models;
using SpeedAlgorithm;
using SpeedAlgorithm.Models;
using Syncfusion.Maui.Charts;

namespace OptimizerTestTool.Pages;

public partial class VizualizationPage : ContentPage
{
    private double _maxSpeed = 160; // Set from train characteristics
    private Optimizer _optimizer;
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
            if (_calcRepo != null)
            {
                if (_calcRepo.RouteConstraints != null && _calcRepo.TimeConstraints != null)
                {
                    InitializeStationPairs();
                    InitializeStateInputs();
                }
            }
        }
    }

    public DateTime BaseTime { get; set; }

    public VizualizationPage(CalculationRepository calcRepo)
    {
        InitializeComponent();
        _optimizer = new Optimizer();

        CalcRepo = calcRepo;
    }

    public DateTime GetDateTimeFromOffset(TimeSpan offset)
    {
        return BaseTime.Add(offset);
    }

    private void RunCalculationAndVisualize()
    {
        BaseTime = CalcRepo.TimeConstraints.TimingPoints.First().DepartureTime.Date;
        _maxSpeed = CalcRepo.TrainCharacteristics.MaxSpeed;

        if (CalcRepo == null || CalcRepo.RouteConstraints == null || CalcRepo.TimeConstraints == null || CalcRepo.TrainCharacteristics == null)
        {
            return;
        }

        var currentState = new TrainState
        {
            Time = GetDateTimeFromOffset(DepartureTimePicker.Time),
            Position = (float)LocationSlider.Value,
            Speed = (float)SpeedSlider.Value
        };

        _optimizer.PreProcess(CalcRepo.RouteConstraints, CalcRepo.TimeConstraints, CalcRepo.TrainCharacteristics, CalcRepo.AlgorithmConfiguration);

        var output =_optimizer.Calculate(currentState);
        VisualizeOutput(output);
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        // Save logic
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        // Delete logic
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        if (!ValidInputs())
            return;
        RunCalculationAndVisualize();
    }

    private void InitializeStationPairs()
    {
        var stops = CalcRepo.TimeConstraints.TimingPoints.Where(tp => tp.IsStop).ToList();
        var pairs = new List<string>();
        for (int i = 0; i < stops.Count - 1; i++)
        {
            pairs.Add($"{stops[i].Name} → {stops[i + 1].Name}");
        }
        StationPairPicker.ItemsSource = pairs;
        StationPairPicker.SelectedIndex = 0;
    }

    private void InitializeStateInputs()
    {
        if (StationPairPicker.SelectedIndex < 0) return;
        var stops = CalcRepo.TimeConstraints.TimingPoints.Where(tp => tp.IsStop).ToList();
        int idx = StationPairPicker.SelectedIndex;
        var from = stops[idx];
        var to = stops[idx + 1];

        DepartureTimePicker.Time = from.DepartureTime.TimeOfDay;
        LocationSlider.Minimum = from.Position;
        LocationSlider.Maximum = to.Position;
        LocationSlider.Value = from.Position;
        SpeedSlider.Minimum = 0;
        SpeedSlider.Maximum = _maxSpeed;
        SpeedSlider.Value = 0;
    }

    private void OnRandomStateClicked(object sender, EventArgs e)
    {
        if (!ValidInputs())
            return;

        var stops = CalcRepo.TimeConstraints.TimingPoints.Where(tp => tp.IsStop).ToList();
        int idx = StationPairPicker.SelectedIndex;
        var from = stops[idx];
        var to = stops[idx + 1];

        // Random time: up to 1 min early, up to next arrival
        var minTime = Math.Max(from.DepartureTime.TimeOfDay.TotalSeconds - 60, 0);
        var maxTime = to.ArrivalTime.TimeOfDay.TotalSeconds;
        var rand = new Random();
        var randomTime = rand.NextDouble() * (maxTime - minTime) + minTime;
        DepartureTimePicker.Time = TimeSpan.FromSeconds(randomTime);

        // Random location between from and to
        var randomLocation = rand.NextDouble() * (to.Position - from.Position) + from.Position;
        LocationSlider.Value = randomLocation;

        // Random speed between 0 and max
        var randomSpeed = rand.NextDouble() * _maxSpeed;
        SpeedSlider.Value = randomSpeed;
        RunCalculationAndVisualize();
    }

    private bool ValidInputs()
    {
        if(CalcRepo == null || CalcRepo.RouteConstraints == null || CalcRepo.TimeConstraints == null || CalcRepo.TrainCharacteristics == null)
        {
            DisplayAlert("Error", "Calculation repository is not properly initialized.", "OK");
            return false;
        }
        return true;
    }

    private void StationPairPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        InitializeStateInputs();
    }

    private void VisualizeOutput(AlgorithmOutput output)
    {
        SpeedChart.Series.Clear();

        // 1. Speed output, color-coded by DrivingMode
        var grouped = output.Items.GroupBy(i => i.DrivingMode);
        foreach (var group in grouped)
        {
            var series = new FastLineSeries
            {
                ItemsSource = group.Select(i => new { Position = i.Position, Speed = i.Speed }),
                XBindingPath = "Position",
                YBindingPath = "Speed",
                Label = group.Key.ToString(),
                PaletteBrushes = new List<Brush> { new SolidColorBrush(Colors.Red) },
                StrokeWidth = 3
            };
            SpeedChart.Series.Add(series);
        }

        // 2. Speed restrictions
        var speedRestrictionSeries = new FastLineSeries
        {
            ItemsSource = CalcRepo.RouteConstraints.SpeedRestrictionSegments.Select(seg => new { Position = seg.Start, Speed = seg.Speed}),
            XBindingPath = "Position",
            YBindingPath = "Speed",
            Label = "Speed Restriction",
            PaletteBrushes = new List<Brush> { new SolidColorBrush(Colors.Red) },
            StrokeDashArray = new DoubleCollection { 4, 2 },
            StrokeWidth = 2
        };
        SpeedChart.Series.Add(speedRestrictionSeries);

        // 3. Altitude (if available)
        if (CalcRepo.RouteConstraints.GradientSegments?.Any() == true)
        {
            var altitudeSeries = new FastLineSeries
            {
                ItemsSource = CalcRepo.RouteConstraints.GradientSegments.Select(seg => new { Position = seg.End, Altitude = seg.Gradient }),
                XBindingPath = "Position",
                YBindingPath = "Altitude",
                Label = "Altitude",
                PaletteBrushes = new List<Brush> { new SolidColorBrush(Colors.Gray) },
                StrokeDashArray = new DoubleCollection { 2, 2 },
                StrokeWidth = 1
            };
            SpeedChart.Series.Add(altitudeSeries);
        }

        // 4. Timing points (drive-through)

        foreach (var tp in CalcRepo.TimeConstraints.TimingPoints.Where(tp => tp.StopType == Shared.Models.Timetable.StopType.DriveThrough))
        {
        }

        SpeedChart.PaletteBrushes = new List<Brush>
        {
            new SolidColorBrush(Colors.Green),
            new SolidColorBrush(Colors.Orange),
            new SolidColorBrush(Colors.Red)
        };
    }

    private Color GetColorForDrivingMode(DrivingMode mode)
    {
        return mode switch
        {
            DrivingMode.Accelerate => Colors.DeepSkyBlue,
            DrivingMode.Coast => Colors.DarkOliveGreen,
            DrivingMode.Brake => Colors.OrangeRed,
            DrivingMode.Cruise => Colors.LightGoldenrodYellow,
            DrivingMode.BrakeAggresive => Colors.DarkRed,
            DrivingMode.AccelerateAggresive => Colors.CornflowerBlue,
            DrivingMode.RegenBrake => Colors.DarkOrange,
            _ => Colors.Black
        };
    }

    private void OnLineToggleChanged(object sender, CheckedChangedEventArgs e)
    {

    }
}