using Shared.Models;
using SpeedOptimizer.Models;
using TrainCharacteristicsManager;

namespace SpeedOptimizer
{
    public class CalcBase
    {
        internal int discInt;

        public AlgorithmConfiguration algorithmConfiguration { get; set; }
        public DynamicsConstraints DynamicsConstraints { get; set; }
        public Constraints constraints { get; set; }
        public TrainState CurrentState { get; set; }
        public ITrainCharacteristics TrainCharacteristics { get; set; }
        public int NumberOfIntervals { get; internal set; }
        public TimeHelper TimeHelper { get; set; }
        public SpeedHelper SpeedHelper { get; set; }
        public Dynamics Dynamics { get; set; }
    }
}