namespace Shared.Models.Route
{
    public class TunnelSegment: Segment
    {
        public float TunnelFactor { get; set; }

        public TunnelSegment(float start, float end, float tunnelFactor)
        {
            Start = start;
            End = end;
            TunnelFactor = tunnelFactor;
        }
    }
}