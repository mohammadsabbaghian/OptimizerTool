using Shared.Models.Route;

namespace SpeedAlgorithm
{
    internal class TunnelHelper
    {
        private double _trainArea;

        public TunnelHelper(double trainArea)
        {
            this._trainArea = trainArea;
        }

        internal List<TunnelSegment> CalculateTunnelFactor(List<TunnelSegment> tunnels)
        {
            throw new NotImplementedException();
        }
    }
}