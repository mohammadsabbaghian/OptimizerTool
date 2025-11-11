using System.Reflection;

namespace Shared.Models.Route
{
    public class RouteConstraints : Segment
    {
        public List<SpeedRestrictionSegment> SpeedRestrictionSegments { get; set; } = new List<SpeedRestrictionSegment>();
        public List<GradientSegment> GradientSegments { get; set; } = new List<GradientSegment>();
        public List<AdhesionLimitationSegment> AdhesionSegments { get; set; } = new List<AdhesionLimitationSegment>();
        public List<PowerLimitSegment> PowerSegments { get; set; } = new List<PowerLimitSegment>();
        public List<SegmentPosition> Points { get; set; } = new List<SegmentPosition>();
        public List<TunnelSegment> Tunnels { get; set; } = new List<TunnelSegment>();
        public List<CurveSegment> Curves { get; set; } = new List<CurveSegment>();
    }
}