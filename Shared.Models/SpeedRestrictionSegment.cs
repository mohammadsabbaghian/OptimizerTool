namespace Shared.Models
{
    public class SpeedRestrictionSegment : Segment
    {
        public double Speed { get; set; }
        public SpeedRestrictionType Type { get; set; }
    }
}