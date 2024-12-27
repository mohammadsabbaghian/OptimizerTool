
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
        public int TractionForce { get; set; }
        public int TractionPower { get; set; }

        public float GetTractionForce(float speed, int curveIndex)
        {
            throw new NotImplementedException();
        }

        public float GetTractionPower(float speed, float tractionPercent)
        {
            throw new NotImplementedException();
        }
    }
}