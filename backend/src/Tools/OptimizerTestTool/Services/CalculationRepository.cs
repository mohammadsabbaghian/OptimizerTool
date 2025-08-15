using Shared.Models;
using Shared.Models.Route;
using Shared.Models.Timetable;
using TrainCharacteristicsManager;

namespace OptimizerTestTool.Services
{
    public class CalculationRepository
    {
        public CalculationRepository()
        {
        }

        public AlgorithmConfiguration AlgorithmConfiguration { get; set; } = new AlgorithmConfiguration();
        public TrainCharacteristicsSimple TrainCharacteristics { get; set; }
        public TimeConstraints TimeConstraints { get; set; }
        public RouteConstraints RouteConstraints { get; set; }
    }
}