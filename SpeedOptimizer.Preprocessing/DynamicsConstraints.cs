namespace SpeedOptimizer
{
    internal class DynamicsConstraints
    {
        public DynamicsConstraints(int numberOfDiscInterval)
        {
            Trackresistance = new float[numberOfDiscInterval];
            TractionCurveIndex = new int[numberOfDiscInterval];
            BrakingCurveIndex = new int[numberOfDiscInterval];
            TunnelFactor = new float[numberOfDiscInterval];

         
            SpeedLimit = new float[numberOfDiscInterval];
            PassagePointIndex = new int[numberOfDiscInterval];
        }

        public float[] Trackresistance { get; set; }
        public int[] TractionCurveIndex { get; set; }
        public int[] BrakingCurveIndex { get; set; }
        public float[] TunnelFactor { get; set; }

        public float[] SpeedLimit { get; set; }
        public int[] PassagePointIndex { get; set; }
    }
}