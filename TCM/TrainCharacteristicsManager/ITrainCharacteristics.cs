using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public interface ITrainCharacteristics
    {
        public List<TrainUnit> TrainUnits { get; set; }
        public Propulsion Propulsion { get; set; }
        public string Class { get; set; }
        public float CurveRes { get; set; }
        public float MechanicalBraking { get; set; }
        public float Mass { get; set; }
        public float Length { get; set; }
        public float DragA { get; set; }
        public float DragB { get; set; }
        public float DragC { get; set; }
        public float MaxSpeed { get; set; }
        public int NumberOfCars { get; set; }
        public TrafficType Type { get; set; }
        double FrontalArea { get; }

        public float GetTractionPower(float speed);
        public float GetTractionForce(float speed);
    }
}