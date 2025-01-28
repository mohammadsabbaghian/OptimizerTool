using Shared.Models;
using SpeedOptimizer.Models;
using TrainCharacteristicsManager;

namespace SpeedOptimizer
{
    public class Dynamics
    {
        private DynamicsConstraints _constraints;
        private int _discInt;
        private ITrainCharacteristics _tc;
        private float _tractionEffDisc;
        private float _brakingEffDisc;

        public Dynamics(DynamicsConstraints constraints, CalcBase calcBase, ITrainCharacteristics trainCharacteristics)
        {
            _constraints = constraints;
            _discInt = calcBase.discInt;
            _tc = trainCharacteristics;
            _tractionEffDisc = _discInt * _tc.TractionEfficiency;
            _brakingEffDisc = _discInt * _tc.RegenEfficiency;
        }

        private float GetRTM(float prevV)
        {
            return _tc.DragA + _tc.DragB * prevV + _tc.DragC * prevV * prevV;
        }

        public void Accelerate(SpeedProfile sp, int i, int offset = 0)
        {
            var curIndex = i + offset;
            var setIndex = i + offset + 1;
            var prevV = sp.Speed[curIndex];
            var resistance = _constraints.Trackresistance[curIndex] + GetRTM(prevV);
            var force = _tc.GetBrakingForce(prevV, _constraints.TractionCurveIndex[curIndex]);

            var speed = prevV + (float)Math.Sqrt(2 * (force - resistance) / _tc.Mass * _discInt);
            var avgSpeed = (sp.Speed[curIndex] + speed) / 2;
            
            resistance = _constraints.Trackresistance[curIndex] + GetRTM(avgSpeed);
            force = _tc.GetBrakingForce(avgSpeed, _constraints.TractionCurveIndex[curIndex]);

            sp.Force[setIndex] = force;
            sp.Speed[setIndex] = prevV + (float)Math.Sqrt(2 * (force - resistance) / _tc.Mass * _discInt);
            avgSpeed = (sp.Speed[curIndex] + sp.Speed[setIndex]) / 2;
            sp.Time[setIndex] = _discInt  / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Accelerate;
            sp.Energy[setIndex] = force* _tractionEffDisc;
        }

        public void AccelerateBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            var curIndex = i + offset - 1;
            var setIndex = i + offset - 1;
            var prevV = sp.Speed[curIndex + 1];
            var resistance = _constraints.Trackresistance[curIndex] + GetRTM(prevV);
            var force = _tc.GetBrakingForce(prevV, _constraints.TractionCurveIndex[curIndex]);

            var speed = prevV - (float)Math.Sqrt(2 * (force - resistance) / _tc.Mass * _discInt);
            var avgSpeed = (sp.Speed[curIndex] + speed) / 2;

            resistance = _constraints.Trackresistance[curIndex] + GetRTM(avgSpeed);
            force = _tc.GetBrakingForce(avgSpeed, _constraints.TractionCurveIndex[curIndex]);

            sp.Force[setIndex] = force;
            sp.Speed[setIndex] = prevV - (float)Math.Sqrt(2 * (force - resistance) / _tc.Mass * _discInt);
            avgSpeed = (sp.Speed[curIndex] + sp.Speed[setIndex]) / 2;
            sp.Time[setIndex] = _discInt / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Accelerate;
            sp.Energy[setIndex] = force * _tractionEffDisc;
        }

        public void Brake(SpeedProfile sp, int i, int offset = 0)
        {
            var curIndex = i + offset;
            var setIndex = i + offset + 1;
            var prevV = sp.Speed[curIndex];

            var resistance = _constraints.Trackresistance[curIndex] + GetRTM(prevV);
            var force = _tc.GetBrakingForce(prevV, _constraints.TractionCurveIndex[curIndex]);

            var speed = prevV + (float)Math.Sqrt(2 * (force - resistance) / _tc.Mass * _discInt);
            var avgSpeed = (sp.Speed[curIndex] + speed) / 2;

            resistance = _constraints.Trackresistance[curIndex] + GetRTM(avgSpeed);
            force = _tc.GetBrakingForce(avgSpeed, _constraints.TractionCurveIndex[curIndex]);

            sp.Force[setIndex] = force;
            sp.Speed[setIndex] = prevV + (float)Math.Sqrt(2 * (force - resistance) / _tc.Mass * _discInt);
            avgSpeed = (sp.Speed[curIndex] + sp.Speed[setIndex]) / 2;
            sp.Time[setIndex] = _discInt / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Brake;
            sp.Energy[setIndex] = force * _brakingEffDisc;
        }

        public void BrakeBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            var curIndex = i + offset - 1;
            var setIndex = i + offset - 1;
            var prevV = sp.Speed[curIndex + 1];

            var resistance = _constraints.Trackresistance[curIndex] + GetRTM(prevV);
            var force = _tc.GetBrakingForce(prevV, _constraints.BrakingCurveIndex[curIndex]);

            var speed = prevV - (float)Math.Sqrt(2 * (force - resistance) / _tc.Mass * _discInt);
            var avgSpeed = (sp.Speed[curIndex] + speed) / 2;

            resistance = _constraints.Trackresistance[curIndex] + GetRTM(avgSpeed);
            force = _tc.GetBrakingForce(avgSpeed, _constraints.BrakingCurveIndex[curIndex]);

            sp.Force[setIndex] = force;
            sp.Speed[setIndex] = prevV - (float)Math.Sqrt(2 * (force - resistance) / _tc.Mass * _discInt);
            avgSpeed = (sp.Speed[curIndex] + sp.Speed[setIndex]) / 2;
            sp.Time[setIndex] = _discInt / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Brake;
            sp.Energy[setIndex] = force * _brakingEffDisc;
        }

        public void Coast(SpeedProfile sp, int i, int offset = 0)
        {
            var curIndex = i + offset;
            var setIndex = i + offset + 1;
            var prevV = sp.Speed[curIndex];

            var resistance = _constraints.Trackresistance[curIndex] + GetRTM(prevV);

            var speed = prevV + (float)Math.Sqrt(2 * (-resistance) / _tc.Mass * _discInt);
            var avgSpeed = (sp.Speed[curIndex] + speed) / 2;

            resistance = _constraints.Trackresistance[curIndex] + GetRTM(avgSpeed);

            sp.Force[setIndex] = 0;
            sp.Speed[setIndex] = prevV + (float)Math.Sqrt(2 * (-resistance) / _tc.Mass * _discInt);
            avgSpeed = (sp.Speed[curIndex] + sp.Speed[setIndex]) / 2;
            sp.Time[setIndex] = _discInt / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Coast;
            sp.Energy[setIndex] = 0;
        }

        public void CoastBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            var curIndex = i + offset - 1;
            var setIndex = i + offset - 1;
            var prevV = sp.Speed[curIndex + 1];

            var resistance = _constraints.Trackresistance[curIndex] + GetRTM(prevV);
            var speed = prevV - (float)Math.Sqrt(2 * (-resistance) / _tc.Mass * _discInt);
            
            var avgSpeed = (sp.Speed[curIndex] + speed) / 2;
            resistance = _constraints.Trackresistance[curIndex] + GetRTM(avgSpeed);

            sp.Force[setIndex] = 0;
            sp.Speed[setIndex] = prevV - (float)Math.Sqrt(2 * (-resistance) / _tc.Mass * _discInt);
            avgSpeed = (sp.Speed[curIndex] + sp.Speed[setIndex]) / 2;
            sp.Time[setIndex] = _discInt / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Coast;
            sp.Energy[setIndex] = 0;
        }

        public void Cruise(SpeedProfile sp, int i, int offset = 0)
        {
            var curIndex = i + offset;
            var setIndex = i + offset + 1;
            var prevV = sp.Speed[curIndex];

            var resistance = _constraints.Trackresistance[curIndex] + GetRTM(prevV);
            var force = _tc.GetBrakingForce(prevV, _constraints.TractionCurveIndex[curIndex]);

            var speed = prevV + (float)Math.Sqrt(2 * (force - resistance) / _tc.Mass * _discInt);
            var avgSpeed = (sp.Speed[curIndex] + speed) / 2;

            resistance = _constraints.Trackresistance[curIndex] + GetRTM(avgSpeed);
            force = _tc.GetBrakingForce(avgSpeed, _constraints.TractionCurveIndex[curIndex]);

            sp.Force[setIndex] = force;
            sp.Speed[setIndex] = prevV + (float)Math.Sqrt(2 * (force - resistance) / _tc.Mass * _discInt);
            avgSpeed = (sp.Speed[curIndex] + sp.Speed[setIndex]) / 2;
            sp.Time[setIndex] = _discInt / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Cruise;
            sp.Energy[setIndex] = force * _discInt;
        }

        public void CruiseBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            var curIndex = i + offset - 1;
            var setIndex = i + offset - 1;
            var prevV = sp.Speed[curIndex + 1];

            var resistance = _constraints.Trackresistance[curIndex] + GetRTM(prevV);
            var force = resistance * _tc.Mass;

            if (force >= 0)
            {
                var availableForce = _tc.GetBrakingForce(prevV, _constraints.TractionCurveIndex[curIndex]);
                if (availableForce < force)
                {
                    AccelerateBackwards(sp, i, offset);
                    return;
                }
                else
                {
                    sp.Energy[setIndex] = force * _tractionEffDisc;
                }
            }
            else
            {
                var availableForce = _tc.GetBrakingForce(prevV, _constraints.BrakingCurveIndex[curIndex]);
                if (availableForce < force)
                {
                    BrakeBackwards(sp, i, offset);
                    return;
                }
                else
                {
                    sp.Energy[setIndex] = force * _discInt * _tc.RegenEfficiency;
                }
            }

            sp.Force[setIndex] = force;
            sp.Speed[setIndex] = prevV;
            sp.Time[setIndex] = _discInt / prevV;
            sp.DrivingMode[setIndex] = DrivingMode.Cruise;
            sp.Energy[setIndex] = force * _discInt;
        }
    }
}