
namespace SpeedOptimizer.Models.Inputs
{
    public class InfrastructureConstraints
    {
        public List<SpeedRestrictionSegment> SpeedRestrictionSegments { get; set; }
        public List<GradientSegment> GradientSegments { get; set; }
        public List<AdhesionSegment> AdhesionSegments { get; set; }
        public List<PowerSegment> PowerSegments { get; set; }
    }
}