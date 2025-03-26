using SpeedAlgorithm.Models;

namespace SpeedAlgorithm
{
    public class DynamicsHelper
    {
        private DynamicsConstraints _constraints;
        private Dynamics _dynamics;
        private CalcBase _calcBase;

        public DynamicsHelper(DynamicsConstraints constraints, Dynamics dynamics, CalcBase calcBase)
        {
            _constraints = constraints;
            _dynamics = dynamics;
            _calcBase = calcBase;
        }

        private int PerformAction(SpeedProfile sp, int i, int offset, float speed, Action<SpeedProfile, int, int> action)
        {
            var methodName = action.Method.Name;
            var minSpeed = (methodName=="Coast") ? _calcBase.algorithmConfiguration.MinimumCoastingSpeed :  _calcBase.algorithmConfiguration.MinimumSpeedAdvice;

            var currentSpeed = sp.Speed[i];
            var nextSpeed = sp.Speed[i + 1];
            int biggerI = currentSpeed >= nextSpeed ? i : i + 1;
            int smallerI = currentSpeed >= nextSpeed ? i + 1 : i;

            while (sp.Speed[biggerI] > sp.Speed[smallerI] && i < sp.Speed.Length - 1)
            {
                biggerI++;
                smallerI++;
                action(sp, i, offset);
                i++;
                if (sp.Speed[i] >= _constraints.SpeedLimits[i + offset] || sp.Speed[i] <= minSpeed)
                {
                    break;
                }
            }
            HandleConnection(sp, i, offset);
            return i;
        }
         private int PerformActionBackwards(SpeedProfile sp, int i, int offset, float speed, Action<SpeedProfile, int, int> action)
        {
            var methodName = action.Method.Name;
            var minSpeed = (methodName == "Coast") ? _calcBase.algorithmConfiguration.MinimumCoastingSpeed : _calcBase.algorithmConfiguration.MinimumSpeedAdvice;
            var currentSpeed = sp.Speed[i];
            var nextSpeed = sp.Speed[i - 1];
            int biggerI = currentSpeed >= nextSpeed ? i : i - 1;
            int smallerI = currentSpeed >= nextSpeed ? i - 1 : i;

            while (sp.Speed[biggerI] > sp.Speed[smallerI] && i > 0)
            {
                biggerI--;
                smallerI--;
                action(sp, i, offset);
                i--;
                if (sp.Speed[i] >= _constraints.SpeedLimits[i + offset] || sp.Speed[i] <= minSpeed)
                {
                    break;
                }
            }
            HandleConnection(sp, i, offset);
            return i;
        }
        private void HandleConnection(SpeedProfile sp, int i, int offset)
        {
            // Implement connection handling logic here
        }

        public int Accelerate(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
        {
            return PerformAction(sp, i, offset, speed, _dynamics.Accelerate);
        }

        public int AccelerateBackwards(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
        {
            return PerformActionBackwards(sp, i, offset, speed, _dynamics.AccelerateBackwards);
        }

        public int Brake(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
        {
            return PerformAction(sp, i, offset, speed, _dynamics.Brake);
        }

        public int BrakeBackwards(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
        {
            return PerformActionBackwards(sp, i, offset, speed, _dynamics.BrakeBackwards);
        }

        public int Coast(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
        {
            return PerformAction(sp, i, offset, speed, _dynamics.Coast);
        }

        public int CoastBackwards(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
        {
            return PerformActionBackwards(sp, i, offset, speed, _dynamics.CoastBackwards);
        }

        public int Cruise(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
        {
            return PerformAction(sp, i, offset, speed, _dynamics.Cruise);
        }

        public int CruiseBackwards(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
        {
            return PerformActionBackwards(sp, i, offset, speed, _dynamics.CruiseBackwards);
        }

        public int Regenerate(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
        {
            return PerformAction(sp, i, offset, speed, _dynamics.Regenerate);
        }

        public int RegenerateBackwards(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
        {
            return PerformActionBackwards(sp, i, offset, speed, _dynamics.RegenerateBackwards);
        }
    }
}
