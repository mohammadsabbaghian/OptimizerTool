using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public class TrainUnitParametersSimple
    {
        public string Class { get; set; }
        public string BaseClassType { get; set; }
        public int CurveRes { get; set; }
        public int MaxPower { get; set; }
        public int MaxForce { get; set; }
        public float TractionEfficiency { get; set; }
        public float BrakingEfficiency { get; set; }
        public float MechanicalBraking { get; set; }
        public int Mass { get; set; }
        public int Length { get; set; }
        public int GragAmass { get; set; }
        public int DragAaxle { get; set; }
        public int DragBmass { get; set; }
        public int DragB { get; set; }
        public int DragC { get; set; }
        public int DeltaDragC { get; set; }
        public double RotatingMassCoefficient { get; set; }
        public int NumberOfCars { get; set; }
        public TrafficType Type { get; set; }
        public Propulsion Propulsion { get; set; }
    }
}
