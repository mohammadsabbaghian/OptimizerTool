using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public class TrainCharacteristicsSimple : TrainCharacteristicsBase, ITrainCharacteristics
    {
        public TrainCharacteristicsSimple()
        {
            // Initialize the object
        }

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