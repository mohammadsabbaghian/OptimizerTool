using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public class TrainUnitParametersSimple : TrainUnitParametersBase
    {
        public string PartitionKey => "TrainUnitParametersSimple";

        public float BrakingForce { get; set; }
        public float BrakingPower { get; set; }
        public int TractionForce { get; set; }
        public int TractionPower { get; set; }
        public float TractionEfficiency { get; set; }
        public float BrakingEfficiency { get; set; }
    }
}
