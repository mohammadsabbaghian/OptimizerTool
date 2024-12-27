using Shared.Models.Train;

namespace TrainCharacteristicsManager.Models
{
    public class ForceCurve
    {
        public SpeedForce[] Curve { get; set; }
        public int Voltage { get; set; }
        public float Frequency { get; set; }
    }
}