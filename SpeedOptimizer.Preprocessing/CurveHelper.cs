using SpeedOptimizer.Models.Inputs;

namespace SpeedOptimizer
{
    public class CurveHelper
    {
        private float _effortInCurveCoefficient;
        private float _gravitationalAcceleration = 9.8f;

        public CurveHelper(float effortInCurve)
        {
            _effortInCurveCoefficient = effortInCurve;
        }

        public GradientSegment[] MergeSegments(CurveSegment[] curveSegments, GradientSegment[] gradientSegments)
        {

            var mergedList = new List<GradientSegment>();
            var curveGradientSegments = curveSegments.Select(curve => new GradientSegment(curve.Start, curve.End, GetCurveGradient(curve))).ToList();

            var allSegments = gradientSegments.Concat(curveGradientSegments).OrderBy(s => s.Start).ToList();

            int i = 0;
            while (i < allSegments.Count)
            {
                var currentSegment = allSegments[i];
                i++;

                while (i < allSegments.Count && currentSegment.End > allSegments[i].Start)
                {
                    var nextSegment = allSegments[i];

                    // Overlap detected
                    var overlapStart = nextSegment.Start;
                    var overlapEnd = Math.Min(currentSegment.End, nextSegment.End);
                    var overlapGradient = currentSegment.Gradient + nextSegment.Gradient;

                    // Add the non-overlapping part of the current segment
                    if (currentSegment.Start < overlapStart)
                    {
                        mergedList.Add(new GradientSegment(currentSegment.Start, overlapStart, currentSegment.Gradient));
                    }

                    // Add the overlapping segment
                    mergedList.Add(new GradientSegment(overlapStart, overlapEnd, overlapGradient));

                    // Update the current segment to the remaining part after the overlap
                    if (overlapEnd < currentSegment.End)
                    {
                        currentSegment = new GradientSegment(overlapEnd, currentSegment.End, currentSegment.Gradient);
                    }
                    else
                    {
                        currentSegment = null;
                        break;
                    }

                    // Update the next segment to the remaining part after the overlap
                    if (overlapEnd < nextSegment.End)
                    {
                        allSegments[i] = new GradientSegment(overlapEnd, nextSegment.End, nextSegment.Gradient);
                    }
                    else
                    {
                        i++;
                    }
                }

                // Add the remaining part of the current segment if it wasn't fully overlapped
                if (currentSegment != null && currentSegment.Start < currentSegment.End)
                {
                    mergedList.Add(currentSegment);
                }
            }

            return mergedList.ToArray();
        }

        private float GetCurveGradient(CurveSegment curve)
        {
            return _effortInCurveCoefficient / Math.Abs(curve.Radius) * curve.Length / _gravitationalAcceleration;
        }
    }
}
