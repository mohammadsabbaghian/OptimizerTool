using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public class TrainCharacteristics : TrainCharacteristicsBase, ITrainCharacteristics
    {
        public PowerMap PowerMap { get; set; }
        public ForceCurve BrakingCurve { get; set; }
        public ForceCurve TractionCurve { get; set; }

        public float GetTractionForce(float speed)
        {
            throw new NotImplementedException();
        }

        public float GetTractionPower(float speed)
        {
            throw new NotImplementedException();
        }
    }
}