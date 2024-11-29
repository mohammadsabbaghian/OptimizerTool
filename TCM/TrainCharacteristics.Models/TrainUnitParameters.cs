using SpeedOptimizer.Models.Inputs;
using TrainCharacteristicsManager;

namespace TrainCharacteristics.Models
{
    public class TrainUnitParameters : TrainUnitParametersBase
    {
        public string PartitionKey => "TrainUnitParameters";
        public PowerMap PowerMap { get; set; }
        public ForceCurve BrakingCurve { get; set; }
        public ForceCurve TractionCurve { get; set; }
    }
}
