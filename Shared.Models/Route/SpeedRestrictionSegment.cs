namespace Shared.Models.Route
{
    public class SpeedRestrictionSegment : Segment
    {
        public double Speed { get; set; }
        public SpeedRestrictionType Type { get; set; }
    }
}