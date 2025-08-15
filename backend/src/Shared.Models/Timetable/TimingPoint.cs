namespace Shared.Models.Timetable
{
    public class TimingPoint
    {
        public string Name { get; set; }
        public double Position { get; set; }
        public StopType StopType { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public int ArrivalTolerance { get; set; }
        public int DepartureTolerance { get; set; }

        public bool IsStop => StopType == StopType.Stop;
    }
}