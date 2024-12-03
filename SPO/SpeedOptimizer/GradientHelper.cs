using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace SpeedOptimizer
{
    public static class GradientHelper
    {
        public static double[] GetWeightedAverageGradientArray(GradientSegment[] gradientSegments, double interval, List<TrainUnit> trainUnits)
        {
            if (gradientSegments == null || !gradientSegments.Any())
                throw new ArgumentException("Gradient segments list cannot be null or empty.");

            if (interval <= 0)
                throw new ArgumentException("Interval must be greater than zero.");

            if (trainUnits == null || !trainUnits.Any())
                throw new ArgumentException("trainUnits list cannot be null or empty.");

            // Determine the length of the output array
            double maxEnd = gradientSegments.Max(gs => gs.End);
            int arrayLength = (int)Math.Ceiling(maxEnd / interval);

            // Initialize the output array
            double[] gradientArray = new double[arrayLength];

            // Populate the output array with weighted average gradient values
            for (int i = 0; i < arrayLength; i++)
            {
                double start = i * interval;
                double end = start + interval;
                var segmentsInRange = gradientSegments.Where(gs => gs.Start < end && gs.End > start).ToList();

                if (segmentsInRange.Any())
                {
                    double totalWeightedGradient = 0;
                    double totalWeight = 0;

                    foreach (var unit in trainUnits)
                    {
                        double rangeStart = Math.Max(unit.Start, start);
                        double rangeEnd = Math.Min(unit.End, end);
                        double rangeLength = rangeEnd - rangeStart;

                        if (rangeLength > 0)
                        {
                            double rangeWeight = unit.TotalMass;

                            foreach (var segment in segmentsInRange)
                            {
                                double segmentStart = Math.Max(segment.Start, rangeStart);
                                double segmentEnd = Math.Min(segment.End, rangeEnd);
                                double segmentLength = segmentEnd - segmentStart;

                                if (segmentLength > 0)
                                {
                                    totalWeightedGradient += segment.Gradient * segmentLength * rangeWeight;
                                    totalWeight += segmentLength * rangeWeight;
                                }
                            }
                        }
                    }

                    gradientArray[i] = totalWeight > 0 ? totalWeightedGradient / totalWeight : 0;
                }
                else
                {
                    // Handle ranges outside the gradient segments
                    double gradientValue = start < gradientSegments[0].Start
                        ? gradientSegments[0].Gradient
                        : gradientSegments[^1].Gradient;

                    gradientArray[i] = gradientValue;
                }
            }

            return gradientArray;
        }

        internal static GradientSegment[] GetGradientSegments(SegmentPosition[] points)
        {
            if (points == null || points.Length < 2)
                throw new ArgumentException("At least two points are required to calculate gradients.");

            GradientSegment[] gradientSegments = new GradientSegment[points.Length - 1];

            for (int i = 0; i < points.Length - 1; i++)
            {
                var start = points[i];
                var end = points[i + 1];

                if (!start.Altitude.HasValue || !end.Altitude.HasValue)
                    throw new ArgumentException("Both start and end points must have altitude values.");

                float gradient = (float)((end.Altitude.Value - start.Altitude.Value) / (end.Position - start.Position));
                gradientSegments[i] = new GradientSegment((float)start.Position, (float)end.Position, gradient);
            }

            return gradientSegments;
        }

    }
}
