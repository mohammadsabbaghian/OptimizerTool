using SpeedOptimizer.Models.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedOptimizer
{
    public static class GradientHelper
    {
        public static double[] GetWeightedAverageGradientArray(List<GradientSegment> gradientSegments, double interval, List<(double start, double end, double weight)> ranges)
        {
            if (gradientSegments == null || !gradientSegments.Any())
                throw new ArgumentException("Gradient segments list cannot be null or empty.");

            if (interval <= 0)
                throw new ArgumentException("Interval must be greater than zero.");

            if (ranges == null || !ranges.Any())
                throw new ArgumentException("Ranges list cannot be null or empty.");

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

                    foreach (var range in ranges)
                    {
                        double rangeStart = Math.Max(range.start, start);
                        double rangeEnd = Math.Min(range.end, end);
                        double rangeLength = rangeEnd - rangeStart;

                        if (rangeLength > 0)
                        {
                            double rangeWeight = range.weight;

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
                    double gradientValue = start < gradientSegments.First().Start
                        ? gradientSegments.First().Gradient
                        : gradientSegments.Last().Gradient;

                    gradientArray[i] = gradientValue;
                }
            }

            return gradientArray;
        }
    }
}
