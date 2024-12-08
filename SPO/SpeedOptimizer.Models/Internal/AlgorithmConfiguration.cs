using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedOptimizer.Models.Internal
{
    internal class AlgorithmConfiguration
    {
        //Stop threshold for punctuality
        public int TimeTolerance { get; set; }

        //Speed in m/s
        public float SpeedDiscretization { get; set; }
        
        //Seconds before lower speed restriction to arrive at that speed
        public int BrakingTolerance { get; set; }

        //Time current acceleration is assumed
        public int ReactionTime { get; set; }

        //Minimum time between acceleration and deceleration
        public int MinimumPeakTime { get; set; }
        
        //Minimum advice
        public float MinimumSpeedAdvice { get; set; }
        
        //Intermediate timings ignored if stop is not feasible
        public bool FinalArrivalMandatory { get; set; }
        
        //intermediate times ignored if too close
        public double MinimumTimeTillFirstPP { get; set; }
        
        //Deceleration advice allowed if arriving too early
        public bool AllowBrakingAdvice{ get; set; }
        
        //Small coasting areas to be avoided
        public double MinCoastingDistance { get; set; }

        //step size for coasting expasion
        public double CoastingStepDistance { get; set; }

        //Maximum Jerk allowed for comfort
        public float JerkLimitation { get; set; }
    }
}
