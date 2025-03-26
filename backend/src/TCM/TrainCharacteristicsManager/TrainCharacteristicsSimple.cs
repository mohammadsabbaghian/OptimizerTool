
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
        public int RegenForce { get; set; }
        public int RegenPower { get; set; }

        public float GetBrakingForce(float speed, int curveIndex)
        {
            return speed == 0 ? BrakingForce : Math.Min(BrakingForce, BrakingPower / speed);
        }

        public float GetBrakingPower(float speed, float tractionPercent)
        {
            return GetBrakingForce(speed, 0) * speed / BrakingEfficiency;
        }

        public float GetRegenForce(float speed, int curveIndex)
        {
            return speed == 0 ? RegenForce : Math.Min(RegenForce, RegenPower / speed);
        }

        public float GetTractionFore(float speed, int curveIndex)
        {
            return speed == 0 ? TractionForce : Math.Min(TractionForce, TractionPower / speed);
        }

        public float GetTractionPower(float speed, float tractionPercent)
        {
            return GetTractionFore(speed, 0) * speed / TractionEfficiency;
        }
    }
}