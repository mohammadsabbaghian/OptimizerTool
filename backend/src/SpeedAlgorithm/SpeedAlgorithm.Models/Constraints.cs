namespace SpeedAlgorithm.Models
{
    public class Constraints
    {
        public Constraints(int numberOfDiscInterval, int discInterval)
        {
            Trackresistances = new float[numberOfDiscInterval];
            TractionCurveIndices = new int[numberOfDiscInterval];
            BrakingCurveIndices = new int[numberOfDiscInterval];
            TunnelFactors = new float[numberOfDiscInterval];
            SpeedLimits = new float[numberOfDiscInterval];
            PassagePointIndices = new int[numberOfDiscInterval];
            NumInts = numberOfDiscInterval;
            DiscInt = discInterval;
        }

        public int DiscInt { get; set; }
        public int NumInts { get; set; }
        public float[] Trackresistances { get; set; }
        public int[] TractionCurveIndices { get; set; }
        public int[] BrakingCurveIndices { get; set; }
        public float[] TunnelFactors { get; set; }
        public float[] SpeedLimits { get; set; }
        public int[] PassagePointIndices { get; set; }
    }
}