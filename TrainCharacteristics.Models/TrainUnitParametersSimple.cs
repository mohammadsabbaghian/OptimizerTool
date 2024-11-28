using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public class TrainUnitParametersSimple : TrainUnitBase
    {
        public int MaxPower { get; set; }
        public int MaxForce { get; set; }
        public float TractionEfficiency { get; set; }
        public float BrakingEfficiency { get; set; }
    }
}
