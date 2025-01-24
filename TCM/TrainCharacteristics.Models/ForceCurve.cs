using Shared.Models.Train;

namespace TrainCharacteristicsManager.Models
{
    public class ForceCurve
    {
        public bool IsMax { get; set; }
        public bool IsDefault { get; set; }
        public float[] Forces { get; set; }
        public int Voltage { get; set; }
        public float Frequency { get; set; }
    }
}