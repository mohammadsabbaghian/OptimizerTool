namespace SpeedOptimizer.Models.Inputs
{
    public class TrainParameters
    {
        public string Class { get; set; }
        public string BaseClassType { get; set; }
        public int CurveRes { get; set; }
        public int Power { get; set; }
        public int Force { get; set; }
        public int Mass { get; set; }
        public int Length { get; set; }
        public int Amass { get; set; }
        public int Aaxle { get; set; }
        public int Bmass { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int dC { get; set; }
        public double RotatingMassCoefficient { get; set; }
        public int NumberOfCars { get; set; }
        public TrafficType Type { get; set; }
    }
}
