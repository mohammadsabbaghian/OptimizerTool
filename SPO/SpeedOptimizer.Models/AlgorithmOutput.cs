namespace SpeedOptimizer.Models
{
    public class AlgorithmOutput
    {
        public AlgorithmOutput()
        {
            Items = new List<AlgorithmOutputItem>();
            TimeResults = new List<TimeResult>();
        }
        public List<AlgorithmOutputItem> Items { get; set; }
        public List<TimeResult> TimeResults { get; set; }
        public EnergyResult EnergyResults { get; set; }
    }
}
