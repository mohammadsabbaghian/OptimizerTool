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

        // New constructor including optional geocoordinates
        public SegmentPosition(double position, string kmReference, double? altitude, double? latitude = null, double? longitude = null)
        {
            Position = position;
            KmReference = kmReference;
            Altitude = altitude;
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Position { get; set; }
        public string KmReference { get; set; }
        public double? Altitude { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}