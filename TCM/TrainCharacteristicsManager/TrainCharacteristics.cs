using TrainCharacteristicsManager.Models;

namespace TrainCharacteristicsManager
{
    public class TrainCharacteristics : TrainCharacteristicsBase, ITrainCharacteristics
    {
        public PowerMap BrakingPowerMap { get; set; }
        public PowerMap TractionPowerMap { get; set; }
        public List<float[]> BrakingCurves { get; set; }
        public List<float[]> TractionCurves { get; set; }

        public TrainCharacteristics(PowerMap tractionPowerMap, PowerMap brakingPowerMap, List<float[]> tractionCurves, List<float[]> brakingCurves)
        {
            BrakingPowerMap = brakingPowerMap;
            TractionPowerMap = tractionPowerMap;
            TractionCurves = tractionCurves;
            BrakingCurves = brakingCurves;
        }

        public float GetTractionFore(float speed, int curveIndex)
        {
            var index = Math.Min(TractionCurves[curveIndex].Length - 1, (int)Math.Round(speed * 3.6,0));
            
            return TractionCurves[curveIndex][index];
        }

        public float GetBrakingForce(float speed, int curveIndex)
        {
            var index = Math.Min(BrakingCurves[curveIndex].Length, (int)Math.Round(speed * 3.6, 0));

            return BrakingCurves[curveIndex][index];
        }

        public float GetBrakingPower(float speed, float tractionPercent)
        {
            var sI = Math.Min(BrakingPowerMap.Speeds.Length - 1, (int)Math.Round(speed * 3.6, 0));
            var tpI = Math.Min(BrakingPowerMap.Powers.Length - 1, (int)Math.Round(tractionPercent, 0));
            return BrakingPowerMap.Powers[tpI, sI];
        }

        public float GetTractionPower(float speed, float tractionPercent)
        {
            var sI = Math.Min(TractionPowerMap.Speeds.Length - 1, (int)Math.Round(speed * 3.6, 0));
            var tpI = Math.Min(TractionPowerMap.Powers.Length - 1, (int)Math.Round(tractionPercent, 0));
            return TractionPowerMap.Powers[tpI, sI];
        }
    }
}