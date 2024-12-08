using Shared.Models;
using TrainCharacteristicsManager;
using TrainCharacteristicsManager.Models;

namespace SpeedOptimizer.Preprocessing
{
    internal class ForceLimitationsHandler
    {
        public ForceCurve[] GetForceCurves(RouteConstraints routeConstraints, ITrainCharacteristics trainCharacteristics)
        {
            ForceCurve[] forceCurves = new ForceCurve[2];

            return forceCurves;
        }
    }
}