using Shared.Models;

namespace SpeedOptimizer
{
    internal class TunnelHelper
    {
        private double _trainArea;

        public TunnelHelper(double trainArea)
        {
            this._trainArea = trainArea;
        }

        internal TunnelSegment[] CalculateTunnelFactor(TunnelSegment[] tunnels)
        {
            throw new NotImplementedException();
        }
    }
}