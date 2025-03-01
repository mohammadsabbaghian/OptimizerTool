using SpeedAlgorithm.Models;

namespace SpeedAlgorithm
{
    public class SpeedHelper
    {
        public void Copy(SpeedProfile origin, SpeedProfile destination)
        {
            for (int i = 0; i < origin.Speed.Length; i++)
            {
                destination.Speed[i] = origin.Speed[i];
                destination.Time[i] = origin.Time[i];
                destination.Force[i] = origin.Force[i];
                destination.Energy[i] = origin.Energy[i];
                destination.DrivingMode[i] = origin.DrivingMode[i];
            }
        }

        public void Copy(SpeedProfile origin, SpeedProfile destination, int startIndex, int endIndex)
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                destination.Speed[i] = origin.Speed[i];
                destination.Time[i] = origin.Time[i];
                destination.Force[i] = origin.Force[i];
                destination.Energy[i] = origin.Energy[i];
                destination.DrivingMode[i] = origin.DrivingMode[i];
            }
        }

        public SpeedProfile Clone(SpeedProfile origin)
        {
            var sp = new SpeedProfile(origin.Speed.Length);
            for (int i = 0; i < origin.Speed.Length; i++)
            {
                sp.Speed[i] = origin.Speed[i];
                sp.Time[i] = origin.Time[i];
                sp.Force[i] = origin.Force[i];
                sp.Energy[i] = origin.Energy[i];
                sp.DrivingMode[i] = origin.DrivingMode[i];
            }
            return sp;
        }

        public SpeedProfile Clone(SpeedProfile origin, int startIndex, int endIndex)
        {
            var sp = new SpeedProfile(endIndex - startIndex);
            for (int i = startIndex; i < endIndex; i++)
            {
                sp.Speed[i - startIndex] = origin.Speed[i];
                sp.Time[i - startIndex] = origin.Time[i];
                sp.Force[i - startIndex] = origin.Force[i];
                sp.Energy[i - startIndex] = origin.Energy[i];
                sp.DrivingMode[i - startIndex] = origin.DrivingMode[i];
            }
            return sp;
        }
    }
}