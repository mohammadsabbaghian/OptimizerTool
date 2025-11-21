using Shared.Models;
using SpeedAlgorithm.Models;
using TrainCharacteristicsManager;
using System;
using System.Runtime.CompilerServices;

namespace SpeedAlgorithm
{
    public class Dynamics
    {
        private readonly Constraints _constraints;
        private readonly float _discInt;
        private readonly float _invMass;
        private readonly ITrainCharacteristics _tc;
        private readonly float _tractionEffDisc;
        private readonly float _brakingEffDisc;

        public Dynamics(Constraints constraints, CalcBase calcBase, ITrainCharacteristics trainCharacteristics)
        {
            _constraints = constraints ?? throw new ArgumentNullException(nameof(constraints));
            _discInt = (float)calcBase.DiscInt;
            _tc = trainCharacteristics ?? throw new ArgumentNullException(nameof(trainCharacteristics));
            _invMass = 1f / _tc.Mass;
            _tractionEffDisc = _discInt * _tc.TractionEfficiency;
            _brakingEffDisc = _discInt * _tc.RegenEfficiency;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private float GetRTM(float v) => _tc.DragA + _tc.DragB * v + _tc.DragC * v * v;

        // --- Accelerate (forward)
        public void Accelerate(SpeedProfile sp, int i, int offset = 0)
        {
            int curIndex = i + offset;
            int setIndex = curIndex + 1;

            float prevV = sp.Speed[curIndex];
            float prevV2 = prevV * prevV;
            float s = _discInt;

            float trackRes = _constraints.Trackresistances[curIndex];
            int tractionIdx = _constraints.TractionCurveIndices[curIndex];

            // evaluate at start
            float resist0 = trackRes + GetRTM(prevV);
            float force0 = _tc.GetTractionFore(prevV, tractionIdx);
            float a0 = (force0 - resist0) * _invMass;

            // predict using a0
            float v1Pred = MathF.Sqrt(prevV2 + 2f * a0 * s);

            // evaluate at average speed
            float avgV = 0.5f * (prevV + v1Pred);
            float resist1 = trackRes + GetRTM(avgV);
            float force1 = _tc.GetTractionFore(avgV, tractionIdx);
            float a1 = (force1 - resist1) * _invMass;

            float aAvg = 0.5f * (a0 + a1);
            float vNext = MathF.Sqrt(prevV2 + 2f * aAvg * s);

            sp.Force[setIndex] = force1;
            sp.Speed[setIndex] = vNext;
            float avgSpeed = 0.5f * (prevV + vNext);
            sp.Time[setIndex] = s / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Accelerate;
            sp.Energy[setIndex] = force1 * _tractionEffDisc;
        }

        // --- AccelerateBackwards
        public void AccelerateBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            int curIndex = i + offset - 1;
            int setIndex = curIndex;

            float prevV = sp.Speed[curIndex + 1];
            float prevV2 = prevV * prevV;
            float s = _discInt;

            float trackRes = _constraints.Trackresistances[curIndex];
            int tractionIdx = _constraints.TractionCurveIndices[curIndex];

            float resist0 = trackRes + GetRTM(prevV);
            float force0 = _tc.GetTractionFore(prevV, tractionIdx);
            float a0 = (force0 - resist0) * _invMass;

            float vPred = MathF.Sqrt(prevV2 - 2f * a0 * s);

            float avgV = 0.5f * (prevV + vPred);
            float resist1 = trackRes + GetRTM(avgV);
            float force1 = _tc.GetTractionFore(avgV, tractionIdx);
            float a1 = (force1 - resist1) * _invMass;

            float aAvg = 0.5f * (a0 + a1);
            float vPrev = MathF.Sqrt(prevV2 - 2f * aAvg * s);

            sp.Force[setIndex] = force1;
            sp.Speed[setIndex] = vPrev;
            float avgSpeed = 0.5f * (prevV + vPrev);
            sp.Time[setIndex] = s / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Accelerate;
            sp.Energy[setIndex] = force1 * _tractionEffDisc;
        }

        // --- Brake (forward)
        public void Brake(SpeedProfile sp, int i, int offset = 0)
        {
            int curIndex = i + offset;
            int setIndex = curIndex + 1;

            float prevV = sp.Speed[curIndex];
            float prevV2 = prevV * prevV;
            float s = _discInt;

            float trackRes = _constraints.Trackresistances[curIndex];
            int brakingIdx = _constraints.BrakingCurveIndices[curIndex];

            float resist0 = trackRes + GetRTM(prevV);
            float force0 = _tc.GetBrakingForce(prevV, brakingIdx);
            float a0 = (force0 - resist0) * _invMass;

            float v1Pred = MathF.Sqrt(prevV2 + 2f * a0 * s);

            float avgV = 0.5f * (prevV + v1Pred);
            float resist1 = trackRes + GetRTM(avgV);
            float force1 = _tc.GetBrakingForce(avgV, brakingIdx);
            float a1 = (force1 - resist1) * _invMass;

            float aAvg = 0.5f * (a0 + a1);
            float vNext = MathF.Sqrt(prevV2 + 2f * aAvg * s);

            sp.Force[setIndex] = force1;
            sp.Speed[setIndex] = vNext;
            float avgSpeed = 0.5f * (prevV + vNext);
            sp.Time[setIndex] = s / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Brake;
            sp.Energy[setIndex] = force1 * _brakingEffDisc;
        }

        // --- BrakeBackwards
        public void BrakeBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            int curIndex = i + offset - 1;
            int setIndex = curIndex;

            float prevV = sp.Speed[curIndex + 1];
            float prevV2 = prevV * prevV;
            float s = _discInt;

            float trackRes = _constraints.Trackresistances[curIndex];
            int brakingIdx = _constraints.BrakingCurveIndices[curIndex];

            float resist0 = trackRes + GetRTM(prevV);
            float force0 = _tc.GetBrakingForce(prevV, brakingIdx);
            float a0 = (force0 - resist0) * _invMass;

            float vPred = MathF.Sqrt(prevV2 - 2f * a0 * s);

            float avgV = 0.5f * (prevV + vPred);
            float resist1 = trackRes + GetRTM(avgV);
            float force1 = _tc.GetBrakingForce(avgV, brakingIdx);
            float a1 = (force1 - resist1) * _invMass;

            float aAvg = 0.5f * (a0 + a1);
            float vPrev = MathF.Sqrt(prevV2 - 2f * aAvg * s);

            sp.Force[setIndex] = force1;
            sp.Speed[setIndex] = vPrev;
            float avgSpeed = 0.5f * (prevV + vPrev);
            sp.Time[setIndex] = s / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Brake;
            sp.Energy[setIndex] = force1 * _brakingEffDisc;
        }

        // --- Regenerate (forward)
        public void Regenerate(SpeedProfile sp, int i, int offset = 0)
        {
            int curIndex = i + offset;
            int setIndex = curIndex + 1;

            float prevV = sp.Speed[curIndex];
            float prevV2 = prevV * prevV;
            float s = _discInt;

            float trackRes = _constraints.Trackresistances[curIndex];
            int regenIdx = _constraints.BrakingCurveIndices[curIndex];

            float resist0 = trackRes + GetRTM(prevV);
            float force0 = _tc.GetRegenForce(prevV, regenIdx);
            float a0 = (force0 - resist0) * _invMass;

            float v1Pred = MathF.Sqrt(prevV2 + 2f * a0 * s);

            float avgV = 0.5f * (prevV + v1Pred);
            float resist1 = trackRes + GetRTM(avgV);
            float force1 = _tc.GetRegenForce(avgV, regenIdx);
            float a1 = (force1 - resist1) * _invMass;

            float aAvg = 0.5f * (a0 + a1);
            float vNext = MathF.Sqrt(prevV2 + 2f * aAvg * s);

            sp.Force[setIndex] = force1;
            sp.Speed[setIndex] = vNext;
            float avgSpeed = 0.5f * (prevV + vNext);
            sp.Time[setIndex] = s / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.RegenBrake;
            sp.Energy[setIndex] = force1 * _brakingEffDisc;
        }

        // --- RegenerateBackwards
        public void RegenerateBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            int curIndex = i + offset - 1;
            int setIndex = curIndex;

            float prevV = sp.Speed[curIndex + 1];
            float prevV2 = prevV * prevV;
            float s = _discInt;

            float trackRes = _constraints.Trackresistances[curIndex];
            int regenIdx = _constraints.BrakingCurveIndices[curIndex];

            float resist0 = trackRes + GetRTM(prevV);
            float force0 = _tc.GetRegenForce(prevV, regenIdx);
            float a0 = (force0 - resist0) * _invMass;

            float vPred = MathF.Sqrt(prevV2 - 2f * a0 * s);

            float avgV = 0.5f * (prevV + vPred);
            float resist1 = trackRes + GetRTM(avgV);
            float force1 = _tc.GetRegenForce(avgV, regenIdx);
            float a1 = (force1 - resist1) * _invMass;

            float aAvg = 0.5f * (a0 + a1);
            float vPrev = MathF.Sqrt(prevV2 - 2f * aAvg * s);

            sp.Force[setIndex] = force1;
            sp.Speed[setIndex] = vPrev;
            float avgSpeed = 0.5f * (prevV + vPrev);
            sp.Time[setIndex] = s / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.RegenBrake;
            sp.Energy[setIndex] = force1 * _brakingEffDisc;
        }

        // --- Coast (forward)
        public void Coast(SpeedProfile sp, int i, int offset = 0)
        {
            int curIndex = i + offset;
            int setIndex = curIndex + 1;

            float prevV = sp.Speed[curIndex];
            float prevV2 = prevV * prevV;
            float s = _discInt;

            float trackRes = _constraints.Trackresistances[curIndex];

            // no drive force (force = 0): net = -resistance
            float resist0 = trackRes + GetRTM(prevV);
            float a0 = (0f - resist0) * _invMass;

            float v1Pred = MathF.Sqrt(prevV2 + 2f * a0 * s);

            float avgV = 0.5f * (prevV + v1Pred);
            float resist1 = trackRes + GetRTM(avgV);
            float a1 = (0f - resist1) * _invMass;

            float aAvg = 0.5f * (a0 + a1);
            float vNext = MathF.Sqrt(prevV2 + 2f * aAvg * s);

            sp.Force[setIndex] = 0f;
            sp.Speed[setIndex] = vNext;
            float avgSpeed = 0.5f * (prevV + vNext);
            sp.Time[setIndex] = s / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Coast;
            sp.Energy[setIndex] = 0f;
        }

        // --- CoastBackwards
        public void CoastBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            int curIndex = i + offset - 1;
            int setIndex = curIndex;

            float prevV = sp.Speed[curIndex + 1];
            float prevV2 = prevV * prevV;
            float s = _discInt;

            float trackRes = _constraints.Trackresistances[curIndex];

            float resist0 = trackRes + GetRTM(prevV);
            float a0 = (0f - resist0) * _invMass;

            float vPred = MathF.Sqrt(prevV2 - 2f * a0 * s);

            float avgV = 0.5f * (prevV + vPred);
            float resist1 = trackRes + GetRTM(avgV);
            float a1 = (0f - resist1) * _invMass;

            float aAvg = 0.5f * (a0 + a1);
            float vPrev = MathF.Sqrt(prevV2 - 2f * aAvg * s);

            sp.Force[setIndex] = 0f;
            sp.Speed[setIndex] = vPrev;
            float avgSpeed = 0.5f * (prevV + vPrev);
            sp.Time[setIndex] = s / avgSpeed;
            sp.DrivingMode[setIndex] = DrivingMode.Coast;
            sp.Energy[setIndex] = 0f;
        }

        // --- Cruise (forward)
        public void Cruise(SpeedProfile sp, int i, int offset = 0)
        {
            int curIndex = i + offset;
            int setIndex = curIndex + 1;

            float prevV = sp.Speed[curIndex];

            float trackRes = _constraints.Trackresistances[curIndex];
            float resistanceForce = trackRes + GetRTM(prevV); // N

            float requiredForce = resistanceForce;

            if (requiredForce >= 0f)
            {
                float available = _tc.GetTractionFore(prevV, _constraints.TractionCurveIndices[curIndex]);
                if (available < requiredForce)
                {
                    AccelerateBackwards(sp, i, offset);
                    return;
                }

                sp.DrivingMode[setIndex] = DrivingMode.Cruise;
                sp.Energy[setIndex] = requiredForce * _tractionEffDisc;
            }
            else
            {
                float available = _tc.GetBrakingForce(prevV, _constraints.BrakingCurveIndices[curIndex]);
                if (available < -requiredForce)
                {
                    BrakeBackwards(sp, i, offset);
                    return;
                }

                sp.DrivingMode[setIndex] = DrivingMode.CruiseDecelerate;
                sp.Energy[setIndex] = (-requiredForce) * _brakingEffDisc;
            }

            sp.Force[setIndex] = requiredForce;
            sp.Speed[setIndex] = prevV;
            sp.Time[setIndex] = _discInt / prevV;
        }

        // --- CruiseBackwards
        public void CruiseBackwards(SpeedProfile sp, int i, int offset = 0)
        {
            int curIndex = i + offset - 1;
            int setIndex = curIndex;

            float prevV = sp.Speed[curIndex + 1];

            float trackRes = _constraints.Trackresistances[curIndex];
            float resistanceForce = trackRes + GetRTM(prevV);

            float requiredForce = resistanceForce;

            if (requiredForce >= 0f)
            {
                float available = _tc.GetTractionFore(prevV, _constraints.TractionCurveIndices[curIndex]);
                if (available < requiredForce)
                {
                    AccelerateBackwards(sp, i, offset);
                    return;
                }

                sp.DrivingMode[setIndex] = DrivingMode.Cruise;
                sp.Energy[setIndex] = requiredForce * _tractionEffDisc;
            }
            else
            {
                float available = _tc.GetBrakingForce(prevV, _constraints.BrakingCurveIndices[curIndex]);
                if (available < -requiredForce)
                {
                    BrakeBackwards(sp, i, offset);
                    return;
                }

                sp.DrivingMode[setIndex] = DrivingMode.CruiseDecelerate;
                sp.Energy[setIndex] = (-requiredForce) * _brakingEffDisc;
            }

            sp.Force[setIndex] = requiredForce;
            sp.Speed[setIndex] = prevV;
            sp.Time[setIndex] = _discInt / prevV;
        }
    }
}
