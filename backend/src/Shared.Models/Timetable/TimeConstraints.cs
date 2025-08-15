namespace Shared.Models.Timetable
{
    public class TimeConstraints
    {
        public string TrainNumber { get; set; }
        public List<TimingPoint> TimingPoints { get; set; }
    }
}