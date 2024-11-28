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

            foreach (var parameter in trainUnits)
            {
                // Build the TrainCharacteristicsSimple object
            }
            return tc;
        }
    }
}
