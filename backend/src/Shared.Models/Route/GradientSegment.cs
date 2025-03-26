namespace Shared.Models.Route
{
    public class GradientSegment : Segment
    {
        public GradientSegment(float start, float end, float gradient)
        {
            Start = start;
            End = end;
            Gradient = gradient;
        }

        public float Gradient { get; set; }
    }
}