using Shared.Models;
using Shared.Models.Route;
using Shared.Models.Timetable;
using SpeedAlgorithm.Models;
using SpeedAlgorithm.Preprocessing;
using TrainCharacteristicsManager;

namespace SpeedAlgorithm
{
    public class CalcBase
    {
        public CalcBase()
        {
            
        }
        public CalcBase(RouteConstraints routeConstraints, TimeConstraints timeConstraints, TrainCharacteristicsSimple trainCharacteristics, AlgorithmConfiguration algorithmConfiguration)
        {
            var preProcessor = new PreProcessor();
            RouteConstraints = routeConstraints;
            TimeConstraints = timeConstraints;
            TrainCharacteristics = trainCharacteristics;
            this.algorithmConfiguration = algorithmConfiguration;

            TimeHelper = new TimeHelper(timeConstraints);
            Constraints = preProcessor.Process(timeConstraints, routeConstraints, trainCharacteristics);
            DiscInt = Constraints.DiscInt;
            TimeHelper = new TimeHelper(timeConstraints);
        }

        public RouteConstraints RouteConstraints;
        public TimeConstraints TimeConstraints;
        public AlgorithmConfiguration algorithmConfiguration { get; set; }
        public Constraints Constraints { get; set; }
        public TrainState CurrentState { get; set; }
        public ITrainCharacteristics TrainCharacteristics { get; set; }
        public TimeHelper TimeHelper { get; set; }
        public Dynamics Dynamics { get; set; }
        public int DiscInt;
        public int NumberOfIntervals { get; internal set; }
    }
}