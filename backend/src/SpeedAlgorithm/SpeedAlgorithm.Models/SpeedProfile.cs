using Shared.Models;

namespace SpeedAlgorithm.Models
{
    public struct SpeedProfile
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


        public bool IsEmpty { get { return Speed == null; } }

        public int Length { get; set; }

        public void CopyFrom(SpeedProfile source, int startIndex, int length)
        {
            Length = length;
            for (int i = 0; i < length; i++)
            {
                int idx = startIndex + i;
                Speed[i] = source.Speed[idx];
                Time[i] = source.Time[idx];
                Energy[i] = source.Energy[idx];
                Force[i] = source.Force[idx];
                DrivingMode[i] = source.DrivingMode[idx];
            }
        }

        public void CopyTo(SpeedProfile destination, int startIndex = 0)
        {
            for (int i = 0; i < Length; i++)
            {
                int idx = startIndex + i;
                destination.Speed[idx] = Speed[i];
                destination.Time[idx] = Time[i];
                destination.Energy[idx] = Energy[i];
                destination.Force[idx] = Force[i];
                destination.DrivingMode[idx] = DrivingMode[i];
            }
        }
    }
}