using Shared.Models;
using Shared.Models.Route;
using Shared.Models.Timetable;
using SpeedAlgorithm.Models;
using TrainCharacteristicsManager;

namespace SpeedAlgorithm
{
    public class Optimizer
    {
        private CalcBase _calcBase;

        public void PreProcess(RouteConstraints routeConstraints, TimeConstraints timeConstraints, TrainCharacteristicsSimple trainCharacteristics, AlgorithmConfiguration algorithmConfiguration)
        {
            _calcBase = new CalcBase(routeConstraints, timeConstraints, trainCharacteristics, algorithmConfiguration);
        }

        public AlgorithmOutput Calculate(TrainState currentState)
        {
            var sp = new SpeedProfile(_calcBase.NumberOfIntervals);

            GetMaxSpeedProfile(sp);

            return CreateOutput(sp);
        }

        private void GetMaxSpeedProfile(SpeedProfile sp)
        {
            _calcBase.Dynamics
        }

        private AlgorithmOutput CreateOutput(SpeedProfile sp)
        {
            var output = new AlgorithmOutput();
            for (int i = 0; i < sp.Speed.Length; i++)
            {
                output.Items.Add(new AlgorithmOutputItem
                {
                    Speed = sp.Speed[i],
                    Time = _calcBase.TimeHelper.ToDateTime(sp.Time[i]),
                    Energy = sp.Energy[i],
                    Force = sp.Force[i],
                    DrivingMode = sp.DrivingMode[i]
                });
            }
            
            output.TimeResults = _calcBase.TimeHelper.GetTimeResults(sp.Time);
            
            output.EnergyResults = new EnergyResult(_calcBase.DiscInt, sp);

            return output;
        }
    }
}
