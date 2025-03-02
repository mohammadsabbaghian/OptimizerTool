using Shared.Models.Route;
using TrainCharacteristicsManager;
using TrainCharacteristicsManager.Models;

namespace SpeedAlgorithm.Preprocessing
{
    internal class ForceLimitationsHandler
    {
        private RouteConstraints _routeConstraints;
        private ITrainCharacteristics _trainCharacteristics;

        public ForceLimitationsHandler(RouteConstraints routeConstraints, ITrainCharacteristics trainCharacteristics)
        {
            _routeConstraints = routeConstraints;
            _trainCharacteristics = trainCharacteristics;
        }
        public ForceCurve[] GetForceCurves(float position)
        {
            var adhesionLimitation = _routeConstraints.AdhesionSegments.FirstOrDefault(x => x.Start <= position && x.End >= position)?.Adhesion ?? 1f;
            var powerLimitation = _routeConstraints.PowerSegments.FirstOrDefault(x => x.Start <= position && x.End >= position)?.PowerLimit ?? 1f;

            ForceCurve[] forceCurves = new ForceCurve[2];

            return forceCurves;
        }
    }
}