using SpeedOptimizer.Helpers;
using Shared.Models;
using SpeedAlgorithm.Models;
using TrainCharacteristicsManager;

namespace SpeedAlgorithm.Helpers
{
    internal interface IRegionFinder
    {
        public interface IOptimizationRegionFinder
        {
            List<Region> FindRegions(
                SpeedProfile profile,
                SlackScopeResult slackResult,
                ITrainCharacteristics train,
                AlgorithmConfiguration config);
        }
    }
}
