
namespace SpeedOptimizer.Models.Inputs
{
    public class InfrastructureConstraints
    {
        public List<SpeedRestrictionSegment> SpeedRestrictionSegments { get; set; }
        public List<GradientSegment> GradientSegments { get; set; }
        public List<AdhesionLimitationSegment> AdhesionSegments { get; set; }
        public List<PowerRestrictionSegment> PowerSegments { get; set; }
        public List<SegmentPosition> Points { get; set; }
        public List<TunnelSegment> Tunnels { get; set; }
        public List<CurveSegment> Curves{ get; set; }
    }
}