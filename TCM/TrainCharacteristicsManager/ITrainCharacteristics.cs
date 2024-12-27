using Shared.Models.Timetable;
using Shared.Models.Train;

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
        public float FrontalArea { get; set; }
        public float[] PreferredBrakingForce { get; set; }
        public double AccelerationBuildup { get; set; }
        public double MinimumCoastingSpeed { get; set; }
        public double SpeedometerDeviation { get; set; }
        public float GetTractionPower(float speed, float tractionPercent);
        public float GetTractionForce(float speed, int curveIndex);

    }
}