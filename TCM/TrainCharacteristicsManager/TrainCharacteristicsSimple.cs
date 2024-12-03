
namespace TrainCharacteristicsManager
{
    public class TrainCharacteristicsSimple : TrainCharacteristicsBase, ITrainCharacteristics
    {
        public TrainCharacteristicsSimple()
        {
            // Initialize the object
        }

        public float TractionEfficiency { get; set; }
        public float BrakingEfficiency { get; set; }
        public float BrakingForce{ get; set; }
        public float BrakingPower { get; set; }
        public int TractionForce { get; internal set; }
        public int TractionPower { get; internal set; }

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