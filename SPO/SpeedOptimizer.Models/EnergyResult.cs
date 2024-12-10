namespace SpeedOptimizer.Models
{
    public class EnergyResult
    {
        public EnergyResult(int discInt, SpeedProfile sp)
        {
            //TO BE VALIDATED BASED ON CHOICE OF SIGNS
            for (int i = 0; i < sp.Energy.Length; i++)
            {
                Total += sp.Energy[i];
                if(sp.Energy[i] < 0)
                {
                    Regenerated -= sp.Energy[i];
                    var optimal = sp.Force[i] * discInt;
                    LostDuringBraking -= sp.Energy[i] + optimal;
                }
                else
                {
                    Used += sp.Energy[i];
                    var optimal = sp.Force[i] * discInt;
                    LostDuringTraction += sp.Energy[i] - optimal;
                }
            }
        }

        public float Used { get; set; }
        public float Regenerated { get; set; }
        public float LostDuringBraking { get; set; }
        public float LostDuringTraction { get; set; }
        public float Total { get; set; }
    }
}