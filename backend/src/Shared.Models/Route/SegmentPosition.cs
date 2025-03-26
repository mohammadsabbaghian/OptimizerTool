namespace Shared.Models.Route
{
    public class SegmentPosition
    {
        public SegmentPosition(double position, string kmReference, float altitude)
        {
            Position = position;
            KmReference = kmReference;
            Altitude = altitude;
        }
        public double Position { get; set; }
        public string KmReference { get; set; }
        public double? Altitude { get; set; }
    }
}