using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public class TrainUnitParameters : TrainUnitBase
    {
        public PowerMap PowerMap { get; set; }
        public ForceCurve BrakingCurve { get; set; }
        public ForceCurve TractionCurve { get; set; }
    }
}
