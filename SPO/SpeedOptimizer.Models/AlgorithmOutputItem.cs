using Shared.Models;

namespace SpeedOptimizer.Models
{
    public class AlgorithmOutputItem
    {
        public double Position { get; set; }
        public DateTime Time { get; set; }
        public double Speed { get; set; }
        public double Force { get; set; }
        public double TractionEnergy { get; set; }
        public double RegenEnergy { get; set; }
        public double DisipatedEnergy { get; set; }
        public double TractionPercentage { get; set; }
        public DrivingMode DrivingMode { get; set; }
        public float Energy { get; set; }
    }
}
