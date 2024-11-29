using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public class TrainUnitParametersBase
    {
        public string Class { get; set; }
        public string BaseClassType { get; set; }
        public float CurveRes { get; set; }
        public float Mass { get; set; }
        public float Length { get; set; }
        public float DragA { get; set; }
        public float DragAmass { get; set; }
        public float DragB { get; set; }
        public float DragBmass { get; set; }
        public float DragC { get; set; }
        public float DeltaDragC { get; set; }
        public float MaxSpeed { get; set; }
        public float RotatingMassCoefficient { get; set; }
        public int NumberOfCars { get; set; }
        public float MechanicalBraking { get; set; }
        public TrafficType Type { get; set; }
        public Propulsion Propulsion { get; set; }
    }
}