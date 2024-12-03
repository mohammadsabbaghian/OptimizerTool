using TrainCharacteristicsManager;
using Shared.Models;

namespace SpeedOptimizer
{
    public class PreProcessor
    {
        public int InitialNumberOfIntervals => 2500;
        public int MinimumDiscretisationInterval => 1;
        public int MaximumDiscretisationInterval => 20;

        public void Process(TimeConstraints timeConstraints, RouteConstraints routeConstraints, TrainCharacteristicsSimple trainCharacteristics)
        {
            var numberOfDiscInterval = GetNumberOfDiscretizationIntervals(routeConstraints.Length);
            var discInterval = GetDiscretizationInterval(routeConstraints.Length, numberOfDiscInterval);

            if (routeConstraints.Curves != null)
            {
                var curveHelper = new CurveHelper(trainCharacteristics.CurveRes);
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

                    routeConstraints.GradientSegments = curveHelper.MergeSegments(routeConstraints.Curves, routeConstraints.GradientSegments);


                    GradientHelper.GetWeightedAverageGradientArray(routeConstraints.GradientSegments, discInterval, trainCharacteristics.TrainUnits);
                }   
            }
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
