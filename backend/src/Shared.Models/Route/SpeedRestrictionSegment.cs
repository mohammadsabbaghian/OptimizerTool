namespace Shared.Models.Route
{
    public class SpeedRestrictionSegment : Segment
    {
        public float Speed { get; set; }
        public SpeedRestrictionType Type { get; set; }
    }
}