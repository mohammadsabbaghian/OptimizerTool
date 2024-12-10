using Shared.Models;
using SpeedOptimizer.Models;

namespace SpeedOptimizer
{
    public class Dynamics
    {
        private DynamicsConstraints _constraints;
        private int _discInt;

        public Dynamics(DynamicsConstraints constraints, CalcBase calcBase)
        {
            _constraints = constraints;
            _discInt = calcBase.discInt;
        }

        public void Accelerate(SpeedProfile sp, int i, int offset = 0)
        {
            sp.Force[i + 1] = 1;
            sp.Speed[i + 1] = sp.Speed[i] + 0.7f;
            var avgSpeed = (sp.Speed[i] + sp.Speed[i + 1]) / 2;
            sp.Time[i + 1] = _discInt  / avgSpeed;
            sp.DrivingMode[i + 1] = DrivingMode.Accelerate;
            sp.Energy[i + 1] = 1;
        }

        public void AccelerateBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            sp.Force[i - 1] = 1;
            sp.Speed[i - 1] = sp.Speed[i] - 0.7f;
            var avgSpeed = (sp.Speed[i] + sp.Speed[i - 1]) / 2;
            sp.Time[i - 1] = _discInt / avgSpeed;
            sp.DrivingMode[i - 1] = DrivingMode.Accelerate;
            sp.Energy[i - 1] = 1;
        }

        public void Brake(SpeedProfile sp, int i, int offset = 0)
        {
            sp.Force[i + 1] = -1;
            sp.Speed[i + 1] = sp.Speed[i] - 0.7f;
            var avgSpeed = (sp.Speed[i] + sp.Speed[i + 1]) / 2;
            sp.Time[i + 1] = _discInt / avgSpeed;
            sp.DrivingMode[i + 1] = DrivingMode.Brake;
            sp.Energy[i + 1] = -1;
        }

        public void BrakeBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            sp.Force[i - 1] = -1;
            sp.Speed[i - 1] = sp.Speed[i] + 0.7f;
            var avgSpeed = (sp.Speed[i] + sp.Speed[i - 1]) / 2;
            sp.Time[i - 1] = _discInt / avgSpeed;
            sp.DrivingMode[i - 1] = DrivingMode.Brake;
            sp.Energy[i - 1] = -1;
        }

        public void Coast(SpeedProfile sp, int i, int offset = 0)
        {
            sp.Force[i + 1] = 0;
            sp.Speed[i + 1] = sp.Speed[i] - 0.1f;
            var avgSpeed = (sp.Speed[i] + sp.Speed[i + 1]) / 2;
            sp.Time[i + 1] = _discInt / avgSpeed;
            sp.DrivingMode[i + 1] = DrivingMode.Coast;
            sp.Energy[i + 1] = 0;
        }

        public void CoastBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            sp.Force[i - 1] = -1;
            sp.Speed[i - 1] = sp.Speed[i] + 0.1f;
            var avgSpeed = (sp.Speed[i] + sp.Speed[i - 1]) / 2;
            sp.Time[i - 1] = _discInt / avgSpeed; ;
            sp.DrivingMode[i - 1] = DrivingMode.Coast;
            sp.Energy[i - 1] = 0;
        }

        public void Cruise(SpeedProfile sp, int i, int offset = 0)
        {
            sp.Force[i + 1] = -1;
            sp.Speed[i + 1] = sp.Speed[i];
            var avgSpeed = (sp.Speed[i] + sp.Speed[i + 1]) / 2;
            sp.Time[i + 1] = _discInt / avgSpeed;
            sp.DrivingMode[i + 1] = DrivingMode.Cruise;
            sp.Energy[i + 1] = 0.5f;
        }

        public void CruiseBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            sp.Force[i - 1] = -1;
            sp.Speed[i - 1] = sp.Speed[i];
            var avgSpeed = (sp.Speed[i] + sp.Speed[i - 1]) / 2;
            sp.Time[i - 1] = _discInt / avgSpeed;
            sp.DrivingMode[i - 1] = DrivingMode.Cruise;
            sp.Energy[i - 1] = 0.5f;
        }
    }
}