using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public class TrainUnitParametersSimple : TrainUnitParametersBase
    {
        public float BrakingForce { get; set; }
        public float BrakingPower { get; set; }
        public int TractionForce { get; internal set; }
        public int TractionPower { get; internal set; }
        public float TractionEfficiency { get; set; }
        public float BrakingEfficiency { get; set; }
    }
}
