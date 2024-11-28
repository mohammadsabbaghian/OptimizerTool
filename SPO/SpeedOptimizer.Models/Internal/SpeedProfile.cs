namespace SpeedOptimizer.Models.Internal
{
    public class SpeedProfile
    {
        public SpeedProfile(int length)
        {
            Speed = new float[length];
            Time = new float[length];
            Force = new float[length];
            Energy = new float[length];
            DrivingMode = new DrivingMode[length];
        }

        public float[] Speed;
        public float[] Time;
        public float[] Energy;
        public float[] Force;
        public DrivingMode[] DrivingMode;
    }
}