using Shared.Models.Route;
using Shared.Models.Timetable;
using SpeedAlgorithm.Models;
using TrainCharacteristicsManager;

namespace SpeedAlgorithm.Preprocessing
{
    public class PreProcessor
    {
        private RouteConstraints _routeConstraints;
        private ITrainCharacteristics _trainCharacteristics;
        private TimeConstraints _timeConstraints;

        public int InitialNumberOfIntervals => 2500;
        public int MinimumDiscretisationInterval => 1;
        public int MaximumDiscretisationInterval => 20;

        public Constraints Process(TimeConstraints timeConstraints, RouteConstraints routeConstraints, ITrainCharacteristics trainCharacteristics)
        {
            _routeConstraints = routeConstraints;
            _trainCharacteristics = trainCharacteristics;
            _timeConstraints = timeConstraints;
            var numberOfDiscInterval = GetNumberOfDiscretizationIntervals(routeConstraints.Length);
            var discInterval = GetDiscretizationInterval(routeConstraints.Length, numberOfDiscInterval);

            if (routeConstraints.GradientSegments == null)
            {
                if (routeConstraints.Points.Any(x => x.Altitude.HasValue))
                {
                    routeConstraints.GradientSegments = GradientHelper.GetGradientSegments(routeConstraints.Points);
                }
                else
                {
                    routeConstraints.GradientSegments = [new GradientSegment(routeConstraints.Start, routeConstraints.End, 0f)];
                }
            }

            if (routeConstraints.Curves.Count > 0)
            {
                var curveHelper = new CurveHelper(trainCharacteristics.CurveRes);
                routeConstraints.GradientSegments = curveHelper.MergeSegments(routeConstraints.Curves, routeConstraints.GradientSegments);
            }

            if(routeConstraints.Tunnels.Count > 0)
            {
                var tunnelHelper = new TunnelHelper(trainCharacteristics.FrontalArea);
                routeConstraints.Tunnels = tunnelHelper.CalculateTunnelFactor(routeConstraints.Tunnels);
            }

            //Handle power and limitations and set traction and braking Curves
            //NEED TO BE THOUGHT OUT
            var forceLimitationHandler = new ForceLimitationsHandler(routeConstraints, trainCharacteristics);
            var forceCurve = forceLimitationHandler.GetForceCurves(0);


            var weighedGradients = GradientHelper.GetWeightedAverageGradientArray(routeConstraints.GradientSegments, discInterval, trainCharacteristics.TrainUnits);

            var constraints = new Constraints(numberOfDiscInterval, discInterval);
            var position = routeConstraints.Start;
            var passagePointIndices = new int[timeConstraints.TimingPoints.Count];
            for (int i = 0; i < timeConstraints.TimingPoints.Count; i++)
            {
                passagePointIndices[i] = (int)Math.Round(timeConstraints.TimingPoints[i].Position - routeConstraints.Start / discInterval, 0);
            }

            for (int i = 0; i <= numberOfDiscInterval; i++)
            {
                position += discInterval;

                constraints.SpeedLimits[i] = _routeConstraints.SpeedRestrictionSegments.Where(x => x.Start <= position && x.End >= position).Min(x => x.Speed);
                constraints.Trackresistances[i] = (float)weighedGradients[i] * 9.81f;
                constraints.TunnelFactors[i] = _routeConstraints.Tunnels.FirstOrDefault(x => x.Start <= position && x.End >= position)?.TunnelFactor ?? 1f;
                constraints.PassagePointIndices[i] = passagePointIndices.FirstOrDefault(x => x >= i);

                //constraints.TractionCurveIndices[i] = 0;
                //constraints.BrakingCurveIndices[i] = 0;
            }


            return constraints;
        }

        private int GetNumberOfDiscretizationIntervals(float totalDistance)
        {
            var discInterval = Math.Min(Math.Max(totalDistance / InitialNumberOfIntervals, MinimumDiscretisationInterval), MaximumDiscretisationInterval);
            return (int)Math.Ceiling((1.0 * totalDistance / discInterval));
        }
        private int GetDiscretizationInterval(float totalDistance, int numberOfIntervals)
        {
            return (int)Math.Round(1.0 * totalDistance / numberOfIntervals);
        }
    }
}
