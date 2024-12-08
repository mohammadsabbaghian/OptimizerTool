namespace SpeedOptimizer
{
    internal class Constraints
    {
        public Constraints(int numberOfDiscInterval, int numTractionCurves, int numBrakingCurves)
        {
            SpeedLimit = new float[numberOfDiscInterval];
            Trackresistance = new float[numberOfDiscInterval];
            TractionCurveIndex = new int[numberOfDiscInterval];
            BrakingCurveIndex = new int[numberOfDiscInterval];
            TractionCurves = new float[numTractionCurves, numberOfDiscInterval];
            BrakingCurves = new float[numBrakingCurves, numberOfDiscInterval];
            PassagePointIndex = new int[numberOfDiscInterval];
            TunnelFactor = new float[numberOfDiscInterval]; 
        }

        public float[] SpeedLimit { get; set; }
        public float[] Trackresistance { get; set; }
        public int[] TractionCurveIndex { get; set; }
        public int[] BrakingCurveIndex { get; set; }
        public float[,] TractionCurves { get; set; }
        public float[,] BrakingCurves { get; set; }
        public int[] PassagePointIndex { get; set; }
        public float[] TunnelFactor { get; set; }
    }
}