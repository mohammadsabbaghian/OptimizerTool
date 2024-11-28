using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public class TrainCharacteristicsBuilder
    {
        public TrainCharacteristicsBuilder(Dictionary<string, TrainUnitParameters> trainParameters)
        {
            this.TrainParameters = trainParameters;
        }

        public Dictionary<string, TrainUnitParameters> TrainParameters { get; private set; }

        public TrainCharacteristicsSimple Build(List<TrainUnit> trainUnits)
        {
            var tc = new TrainCharacteristicsSimple();

            var end = 0f;
            foreach (var unit in trainUnits)
            {
                unit.Start = end;
                end = end + (int)unit.Length;
                unit.End = end;
            }
            return tc;
        }
    }
}
