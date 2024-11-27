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

        public TrainCharacteristics Build(List<TrainUnit> trainParameters)
        {
            var tc = new TrainCharacteristics();

            foreach (var parameter in trainParameters)
            {
                // Build the TrainCharacteristics object
            }
            return tc;
        }
    }
}
