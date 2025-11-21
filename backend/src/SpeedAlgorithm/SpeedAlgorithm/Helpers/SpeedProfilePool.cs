using Shared.Models;
using SpeedAlgorithm.Models;
using System.Buffers;

namespace SpeedOptimizer.Helpers
{
    /// <summary>
    /// Pool for SpeedProfile that rents/returns arrays from ArrayPool.
    /// Grows as needed; no fixed cap.
    /// </summary>
    public static class SpeedProfilePool
    {
        private static readonly ArrayPool<float> FloatPool = ArrayPool<float>.Shared;
        private static readonly ArrayPool<DrivingMode> ModePool = ArrayPool<DrivingMode>.Shared;

        public static SpeedProfile Rent(int length)
        {
            var slice = new SpeedProfile
            {
                Speed = FloatPool.Rent(length),
                Time = FloatPool.Rent(length),
                Energy = FloatPool.Rent(length),
                Force = FloatPool.Rent(length),
                DrivingMode = ModePool.Rent(length),
                Length = length
            };

            return slice;
        }

        public static void Return(SpeedProfile slice)
        {
            if (slice.Speed.Length > 0)
                FloatPool.Return(slice.Speed, clearArray: false);
            if (slice.Time.Length > 0)
                FloatPool.Return(slice.Time, clearArray: false);
            if (slice.Energy.Length > 0)
                FloatPool.Return(slice.Energy, clearArray: false);
            if (slice.Force.Length > 0)
                FloatPool.Return(slice.Force, clearArray: false);
            if (slice.DrivingMode.Length > 0)
                ModePool.Return(slice.DrivingMode, clearArray: false);

            slice.Speed = Array.Empty<float>();
            slice.Time = Array.Empty<float>();
            slice.Energy = Array.Empty<float>();
            slice.Force = Array.Empty<float>();
            slice.DrivingMode = Array.Empty<DrivingMode>();
            slice.Length = 0;
        }
    }
}
