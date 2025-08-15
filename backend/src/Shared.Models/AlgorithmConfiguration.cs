namespace Shared.Models
{
    public class AlgorithmConfiguration
    {
        public AlgorithmConfiguration() { }

        public AlgorithmConfiguration(bool withDefaultValues = true)
        {
            if (withDefaultValues)
            {
                // Speed related
                SpeedDiscretization = 5f / 3.6f;
                MinimumSpeedAdvice = 30f / 0.5f;
                JerkLimitation = 0.7f;
                MinimumCoastingSpeed = 0.0f;

                // Distance related
                MinCoastingDistance = 500.0;
                CoastingStepDistance = 20.0;
                FinalAdviceThreshold = 400;

                // Time related
                MinTimeTillFirstTimingPoint = 30.0;
                BrakingTimeTolerance = 5;
                MinimumPeakTime = 15;
                ReactionTime = 5;
                CalculationTimeTolerance = 2;
                MaxCalculationTime = 1;

                FinalArrivalMandatory = true;
                AllowBrakingAdvice = false;
            }
        }

        //Stop threshold for punctuality
        public int CalculationTimeTolerance { get; set; }

        //Total calculation time allowed
        public int MaxCalculationTime { get; set; }

        //Speed in m/s
        public float SpeedDiscretization { get; set; }

        //Seconds before lower speed restriction to arrive at that speed
        public int BrakingTimeTolerance { get; set; }

        //Time current acceleration is assumed
        public int ReactionTime { get; set; }

        //Minimum time between acceleration and deceleration
        public int MinimumPeakTime { get; set; }

        //Minimum advice
        public float MinimumSpeedAdvice { get; set; }

        //Intermediate timings ignored if stop is not feasible
        public bool FinalArrivalMandatory { get; set; }

        //intermediate times ignored if too close
        public double MinTimeTillFirstTimingPoint { get; set; }

        //Deceleration advice allowed if arriving too early
        public bool AllowBrakingAdvice { get; set; }

        //Small coasting areas to be avoided
        public double MinCoastingDistance { get; set; }

        //step size for coasting expasion
        public double CoastingStepDistance { get; set; }

        //Before the arrival, advice is hidden and should preferably not change.
        public int FinalAdviceThreshold { get; set; }

        //Maximum Jerk allowed for comfort
        public float JerkLimitation { get; set; }
        public float MinimumCoastingSpeed { get; set; }
    }
}
