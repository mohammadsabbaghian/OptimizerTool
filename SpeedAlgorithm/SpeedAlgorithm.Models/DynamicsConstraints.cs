namespace SpeedAlgorithm.Models
{
    public class DynamicsConstraints
    {
        public DynamicsConstraints(int numberOfDiscInterval)
        {
            Trackresistances = new float[numberOfDiscInterval];
            TractionCurveIndices = new int[numberOfDiscInterval];
            BrakingCurveIndices = new int[numberOfDiscInterval];
            TunnelFactors = new float[numberOfDiscInterval];

            SpeedLimits = new float[numberOfDiscInterval];
            PassagePointIndices = new int[numberOfDiscInterval];
        }

        public float[] Trackresistances { get; set; }
        public int[] TractionCurveIndices { get; set; }
        public int[] BrakingCurveIndices { get; set; }
        public float[] TunnelFactors { get; set; }

        public float[] SpeedLimits { get; set; }
        public int[] PassagePointIndices { get; set; }
    }
}