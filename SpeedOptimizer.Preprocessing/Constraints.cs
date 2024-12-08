namespace SpeedOptimizer
{
    internal class Constraints
    {
        public Constraints(int numberOfDiscInterval)
        {
            SpeedLimit = new float[numberOfDiscInterval];
            PassagePointIndex = new int[numberOfDiscInterval];
        }

        public float[] SpeedLimit { get; set; }
        public int[] PassagePointIndex { get; set; }
    }
}