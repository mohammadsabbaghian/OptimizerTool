
namespace SpeedOptimizer.Models
{
    internal class AlgorithmOutputItem
    {
        public double Position { get; set; }
        public DateTime Time { get; set; }
        public double Speed { get; set; }
        public double Force { get; set; }
        public double TractionEnegy { get; set; }
        public double RegenEnegy { get; set; }
        public double WastedEnegy { get; set; }
        public double TractionPercentage { get; set; }
        public DrivingMode DrivingMode { get; set; }

        public double Altitude { get; set; }
        public double TrackResistance { get; set; }
        public double TrainResistance { get; set; }
        public double SpeedRestriction { get; set; }
    }
}
