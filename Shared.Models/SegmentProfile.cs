namespace Shared.Models
{
    public class RouteConstraints : Segment
    {
        public SpeedRestrictionSegment[] SpeedRestrictionSegments { get; set; }
        public GradientSegment[] GradientSegments { get; set; }
        public AdhesionLimitationSegment[] AdhesionSegments { get; set; }
        public PowerLimitSegment[] PowerSegments { get; set; }
        public SegmentPosition[] Points { get; set; }
        public TunnelSegment[] Tunnels { get; set; }
        public CurveSegment[] Curves { get; set; }
    }
}