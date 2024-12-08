using Shared.Models;
using SpeedOptimizer.Preprocessing;
using TrainCharacteristicsManager;

namespace SpeedOptimizer
{
    public class PreProcessor
    {
        public int InitialNumberOfIntervals => 2500;
        public int MinimumDiscretisationInterval => 1;
        public int MaximumDiscretisationInterval => 20;

        public void Process(TimeConstraints timeConstraints, RouteConstraints routeConstraints, ITrainCharacteristics trainCharacteristics)
        {
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

            if (routeConstraints.Curves.Length > 0)
            {
                var curveHelper = new CurveHelper(trainCharacteristics.CurveRes);
                routeConstraints.GradientSegments = curveHelper.MergeSegments(routeConstraints.Curves, routeConstraints.GradientSegments);
            }

            if(routeConstraints.Tunnels.Length > 0)
            {
                var tunnelHelper = new TunnelHelper(trainCharacteristics.FrontalArea);
                routeConstraints.Tunnels = tunnelHelper.CalculateTunnelFactor(routeConstraints.Tunnels);
            }

            //Handle power and limitations and set traction and braking Curves
            //NEED TO BE THOUGHT OUT
            var forceLimitationHandler = new ForceLimitationsHandler();
            

            var constraints = new DynamicsConstraints(numberOfDiscInterval);
            for (int i = 0; i < numberOfDiscInterval; i++)
            {

            }


            var weighedGradients = GradientHelper.GetWeightedAverageGradientArray(routeConstraints.GradientSegments, discInterval, trainCharacteristics.TrainUnits);


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
