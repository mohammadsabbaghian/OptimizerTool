using Shared.Models;
using SpeedAlgorithm.Models;

namespace SpeedAlgorithm
{
    public class SpeedAlgorithm
    {
        private CalcBase _calcBase;

        public SpeedAlgorithm(CalcBase calcBase) 
        {
            _calcBase = calcBase;
        }

        public AlgorithmOutput Calculate(TrainState currentState)
        {
            var sp = new SpeedProfile(_calcBase.NumberOfIntervals);

            GetMaxSpeedProfile(sp);


            return CreateOutput(sp);
        }

        private void GetMaxSpeedProfile(SpeedProfile sp)
        {
            throw new NotImplementedException();

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
            
            output.EnergyResults = new EnergyResult(_calcBase.discInt, sp);

            return output;
        }
    }
}
