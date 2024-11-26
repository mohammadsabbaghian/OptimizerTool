namespace SpeedOptimizer.Models.Inputs
{
    public class TimingPoint
    {
        public string Name { get; set; }
        public double Position { get; set; }
        public StopType StopType { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public TimeSpan ArrivalTolerance { get; set; }
        public TimeSpan DepartureTolerance{ get; set; }
    }
}