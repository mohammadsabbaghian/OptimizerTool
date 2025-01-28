using TrainCharacteristicsManager.Models;

namespace TrainCharacteristicsManager
{
    public class TrainCharacteristics : TrainCharacteristicsBase, ITrainCharacteristics
    {
        public PowerMap PowerMap { get; set; }
        public List<float[]> BrakingCurves { get; set; }
        public List<float[]> TractionCurves { get; set; }

        public float GetBrakingForce(float speed, int curveIndex)
        {
            var index = Math.Min(TractionCurves[curveIndex].Length, (int)Math.Round(speed * 3.6,0));
            
            return TractionCurves[curveIndex][index];
        }

        public float GetTractionPower(float speed, float tractionPercent)
        {
            throw new NotImplementedException();
        }
    }
}