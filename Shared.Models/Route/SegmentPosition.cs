namespace Shared.Models.Route
{
    public class SegmentPosition
    {
        public SegmentPosition(double position, string kmReference)
        {
            Position = position;
            KmReference = kmReference;
        }
        public double Position { get; set; }
        public double? Altitude { get; set; }
        public string KmReference { get; set; }
    }
}