namespace Shared.Models.Route
{
    public class CurveSegment : Segment
    {
        public CurveSegment()
        {
            
        }
        public CurveSegment(float start, float end, float radius)
        {
            Start = start;
            End = end;
            Radius = radius;
        }

        public float Radius { get; set; }
    }
}