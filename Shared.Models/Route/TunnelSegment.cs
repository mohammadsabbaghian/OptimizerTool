namespace Shared.Models.Route
{
    public class TunnelSegment: Segment
    {
        public double TunnelFactor { get; set; }

        public TunnelSegment(float start, float end, double tunnelFactor)
        {
            Start = start;
            End = end;
            TunnelFactor = tunnelFactor;
        }
    }
}