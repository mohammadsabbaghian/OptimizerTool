namespace SpeedOptimizer.Models.Inputs
{
    public class TrainUnit
    {
        public string Class { get; set; }
        public float TotalMass { get; set; }
        public float Length { get; set; }
        public float TractionPercentage { get; set; }
        public float BrakeWeightPercentage { get; set; }
        public float Start { get; set; }
        public float End { get; set; }
    }
}