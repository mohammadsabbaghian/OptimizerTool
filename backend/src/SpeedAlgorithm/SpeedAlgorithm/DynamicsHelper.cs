using Shared.Models;
using SpeedAlgorithm.Models;
using System;

namespace SpeedAlgorithm
{
    public class DynamicsHelper
    {
        private readonly Constraints _constraints;
        private readonly Dynamics _dynamics;
        private readonly CalcBase _calcBase;

        public DynamicsHelper(Constraints constraints, Dynamics dynamics, CalcBase calcBase)
        {
            _constraints = constraints ?? throw new ArgumentNullException(nameof(constraints));
            _dynamics = dynamics ?? throw new ArgumentNullException(nameof(dynamics));
            _calcBase = calcBase ?? throw new ArgumentNullException(nameof(calcBase));
        }

        // Mode dispatch code: cheap integer mapping
        private static int ModeToCode(DrivingMode mode)
        {
            switch (mode)
            {
                case DrivingMode.Accelerate: return 0;
                case DrivingMode.Coast: return 1;
                case DrivingMode.Cruise: return 2;
                case DrivingMode.Brake: return 3;
                case DrivingMode.RegenBrake: return 4;
                default: return -1;
            }
        }

        // Forward calculation loop
        private int Calculate(SpeedProfile sp, int i, int offset, float speedIgnored, DrivingMode mode)
        {
            var speedArr = sp.Speed;
            var speedLimits = _constraints.SpeedLimits;
            int maxIndex = speedArr.Length - 1;

            float minSpeed = (mode == DrivingMode.Coast)
                ? _calcBase.algorithmConfiguration.MinimumCoastingSpeed
                : _calcBase.algorithmConfiguration.MinimumSpeedAdvice;

            int modeCode = ModeToCode(mode);

            if (i >= maxIndex) { HandleConnection(sp, i, offset); return i; }

            // Determine initial monotonicity direction using (i, i+1)
            float cur = speedArr[i];
            float neigh = speedArr[i + 1];
            int biggerI = cur >= neigh ? i : i + 1;
            int smallerI = cur >= neigh ? i + 1 : i;

            bool overshot = false;
            bool impossible = false;
            bool reachedBoundary = false;

            // first action at starting index
            InvokeDynamicsForward(modeCode, sp, i, offset);

            // step into newly written cell
            i++;
            if (i > maxIndex) { reachedBoundary = true; HandleConnection(sp, i, offset, mode, overshot, impossible, reachedBoundary); return i; }
            biggerI++; smallerI++;

            // continue while the original monotonicity holds
            while (i < maxIndex && speedArr[biggerI] > speedArr[smallerI])
            {
                float newSpeed = speedArr[i];
                float limit = speedLimits[i + offset];

                // speed limit exceeded -> clamp and treat as cruise/transition
                if (!float.IsNaN(newSpeed) && newSpeed > limit)
                {
                    // clamp to limit
                    float target = limit;
                    sp.Speed[i] = target;
                    sp.DrivingMode[i] = DrivingMode.Cruise;

                    // attempt fractional correction on previous interval
                    TryFractionalCorrectionForward(sp, i - 1, i, target, mode);

                    overshot = true;
                    break;
                }

                // dropped below minimum speed -> clamp to min and cruise
                if (!float.IsNaN(newSpeed) && newSpeed <= minSpeed)
                {
                    float target = minSpeed;
                    sp.Speed[i] = target;
                    sp.DrivingMode[i] = DrivingMode.Cruise;

                    TryFractionalCorrectionForward(sp, i - 1, i, target, mode);

                    overshot = true;
                    break;
                }

                // NaN encountered -> impossible region
                if (float.IsNaN(newSpeed))
                {
                    impossible = true;
                    break;
                }

                // call dynamics for the next step
                InvokeDynamicsForward(modeCode, sp, i, offset);

                // advance into the newly written cell
                i++;
                if (i > maxIndex) { reachedBoundary = true; break; }
                biggerI++; smallerI++;
            }

            HandleConnection(sp, i, offset, mode, overshot, impossible, reachedBoundary);
            return i;
        }

        // Backwards calculation loop
        private int CalculateBackwards(SpeedProfile sp, int i, int offset, float speedIgnored, DrivingMode mode)
        {
            var speedArr = sp.Speed;
            var speedLimits = _constraints.SpeedLimits;

            float minSpeed = (mode == DrivingMode.Coast)
                ? _calcBase.algorithmConfiguration.MinimumCoastingSpeed
                : _calcBase.algorithmConfiguration.MinimumSpeedAdvice;

            int modeCode = ModeToCode(mode);

            if (i <= 0) { HandleConnection(sp, i, offset); return i; }

            // Determine initial monotonicity direction using (i, i-1)
            float cur = speedArr[i];
            float neigh = speedArr[i - 1];
            int biggerI = cur >= neigh ? i : i - 1;
            int smallerI = cur >= neigh ? i - 1 : i;

            bool overshot = false;
            bool impossible = false;
            bool reachedBoundary = false;

            // first backward action
            InvokeDynamicsBackward(modeCode, sp, i, offset);

            // step into the newly written cell
            i--;
            if (i < 0) { reachedBoundary = true; HandleConnection(sp, i, offset, mode, overshot, impossible, reachedBoundary); return i; }
            biggerI--; smallerI--;

            while (i > 0 && speedArr[biggerI] > speedArr[smallerI])
            {
                float newSpeed = speedArr[i];
                float limit = speedLimits[i + offset];

                if (!float.IsNaN(newSpeed) && newSpeed > limit)
                {
                    float target = limit;
                    sp.Speed[i] = target;
                    sp.DrivingMode[i] = DrivingMode.Cruise;
                    TryFractionalCorrectionBackward(sp, i, i + 1, target, mode);
                    overshot = true;
                    break;
                }

                if (!float.IsNaN(newSpeed) && newSpeed <= minSpeed)
                {
                    float target = minSpeed;
                    sp.Speed[i] = target;
                    sp.DrivingMode[i] = DrivingMode.Cruise;
                    TryFractionalCorrectionBackward(sp, i, i + 1, target, mode);
                    overshot = true;
                    break;
                }

                if (float.IsNaN(newSpeed))
                {
                    impossible = true;
                    break;
                }

                // call next backward dynamics
                InvokeDynamicsBackward(modeCode, sp, i, offset);

                i--;
                if (i < 0) { reachedBoundary = true; break; }
                biggerI--; smallerI--;
            }

            HandleConnection(sp, i, offset, mode, overshot, impossible, reachedBoundary);
            return i;
        }

        // Public API wrappers unchanged
        public int Accelerate(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
            => Calculate(sp, i, offset, speed, DrivingMode.Accelerate);

        public int AccelerateBackwards(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
            => CalculateBackwards(sp, i, offset, speed, DrivingMode.Accelerate);

        public int Brake(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
            => Calculate(sp, i, offset, speed, DrivingMode.Brake);

        public int BrakeBackwards(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
            => CalculateBackwards(sp, i, offset, speed, DrivingMode.Brake);

        public int Coast(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
            => Calculate(sp, i, offset, speed, DrivingMode.Coast);

        public int CoastBackwards(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
            => CalculateBackwards(sp, i, offset, speed, DrivingMode.Coast);

        public int Cruise(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
            => Calculate(sp, i, offset, speed, DrivingMode.Cruise);

        public int CruiseBackwards(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
            => CalculateBackwards(sp, i, offset, speed, DrivingMode.Cruise);

        public int Regenerate(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
            => Calculate(sp, i, offset, speed, DrivingMode.RegenBrake);

        public int RegenerateBackwards(SpeedProfile sp, int i, int offset = 0, float speed = float.MaxValue)
            => CalculateBackwards(sp, i, offset, speed, DrivingMode.RegenBrake);

        // Helper: invokes forward dynamics based on modeCode
        private void InvokeDynamicsForward(int modeCode, SpeedProfile sp, int i, int offset)
        {
            switch (modeCode)
            {
                case 0: _dynamics.Accelerate(sp, i, offset); break;
                case 1: _dynamics.Coast(sp, i, offset); break;
                case 2: _dynamics.Cruise(sp, i, offset); break;
                case 3: _dynamics.Brake(sp, i, offset); break;
                case 4: _dynamics.Regenerate(sp, i, offset); break;
                default: throw new ArgumentOutOfRangeException(nameof(modeCode));
            }
        }

        // Helper: invokes backward dynamics based on modeCode
        private void InvokeDynamicsBackward(int modeCode, SpeedProfile sp, int i, int offset)
        {
            switch (modeCode)
            {
                case 0: _dynamics.AccelerateBackwards(sp, i, offset); break;
                case 1: _dynamics.CoastBackwards(sp, i, offset); break;
                case 2: _dynamics.CruiseBackwards(sp, i, offset); break;
                case 3: _dynamics.BrakeBackwards(sp, i, offset); break;
                case 4: _dynamics.RegenerateBackwards(sp, i, offset); break;
                default: throw new ArgumentOutOfRangeException(nameof(modeCode));
            }
        }

        // Fractional-step correction for forward overshoot/clamp:
        // prevIdx = i-1, finalIdx = i (clamped to 'target')
        // Try to compute s_frac so that v_prev^2 + 2 * a_avg * s_frac = target^2.
        // Uses a simple average-acceleration estimate derived from the full step. If a is invalid, do nothing.
        private void TryFractionalCorrectionForward(SpeedProfile sp, int prevIdx, int finalIdx, float targetSpeed, DrivingMode mode)
        {
            // bounds check
            if (prevIdx < 0 || finalIdx >= sp.Speed.Length) return;

            float vPrev = sp.Speed[prevIdx];
            float vFull = sp.Speed[finalIdx]; // already clamped to targetSpeed by caller
            float s = _constraints.DiscInt;

            // If either is NaN or negative (unexpected), skip correction
            if (float.IsNaN(vPrev) || float.IsNaN(vFull)) return;

            // compute full-step squared diff; if identical speeds there's nothing to do
            float vPrev2 = vPrev * vPrev;
            float vFull2 = vFull * vFull;
            if (vFull2 == vPrev2) return;

            // estimate average acceleration a_est from the full (unclamped) prediction if available.
            // We attempt to reconstruct acceleration from the previous un-clamped value if possible.
            // If the pre-clamp value is not available (we overwrote it), use a finite-difference acceleration estimate:
            // a_est = (v_full^2 - vPrev^2) / (2*s)
            float aEst = (vFull2 - vPrev2) / (2f * s);

            // If aEst is zero, we cannot solve for s_frac safely.
            if (aEst == 0f) return;

            // compute s_frac to reach targetSpeed exactly from vPrev
            float target2 = targetSpeed * targetSpeed;
            float sNeeded = (target2 - vPrev2) / (2f * aEst);

            // accept only sensible fractions
            if (!(sNeeded > 0f && sNeeded < s)) return;

            float frac = sNeeded / s;

            // recompute approximate intermediate speed at fractional point
            float vMid2 = vPrev2 + 2f * aEst * sNeeded;
            float vMid = (vMid2 >= 0f) ? MathF.Sqrt(vMid2) : float.NaN;

            // update prev interval outputs to reflect the fractional step
            // prev interval now covers distance sNeeded and final cell covers remaining s - sNeeded
            // recompute times based on avg speeds (approx)
            float timePrev = (vPrev + vMid) != 0f ? sNeeded / ((vPrev + vMid) * 0.5f) : float.PositiveInfinity;
            float vNext = targetSpeed;
            float timeFinal = (vMid + vNext) != 0f ? (s - sNeeded) / ((vMid + vNext) * 0.5f) : float.PositiveInfinity;

            // Update arrays
            sp.Time[prevIdx] = timePrev;
            sp.Time[finalIdx] = timeFinal;

            // Consider marking DrivingMode for prevIdx as a transition (if enum supports it), otherwise leave as-is.
            // If you have a Transition mode, use it; otherwise set to the current mode for cleanliness.
            // Example: sp.DrivingMode[finalIdx] = DrivingMode.Transition;
            // Fallback:
            sp.DrivingMode[prevIdx] = sp.DrivingMode[prevIdx]; // keep existing
            sp.DrivingMode[finalIdx] = DrivingMode.Cruise;     // end at Cruise (clamped)
        }

        // Fractional-step correction for backward overshoot/clamp:
        // finalIdx = i+1 (the cell that was clamped), prevIdx = i
        private void TryFractionalCorrectionBackward(SpeedProfile sp, int prevIdx, int finalIdx, float targetSpeed, DrivingMode mode)
        {
            // prevIdx is lower index, finalIdx is higher index
            if (prevIdx < 0 || finalIdx >= sp.Speed.Length) return;

            float vNext = sp.Speed[finalIdx];
            float vPrev = sp.Speed[prevIdx]; // clamped to target if caller set it
            float s = _constraints.DiscInt;

            if (float.IsNaN(vPrev) || float.IsNaN(vNext)) return;

            float vPrev2 = vPrev * vPrev;
            float vNext2 = vNext * vNext;
            if (vNext2 == vPrev2) return;

            // estimate aEst from finite difference
            float aEst = (vNext2 - vPrev2) / (2f * s);
            if (aEst == 0f) return;

            // sNeeded backward: how much distance (from finalIdx backwards) is required to reach targetSpeed
            float target2 = targetSpeed * targetSpeed;
            float sNeeded = (vNext2 - target2) / (2f * aEst);

            if (!(sNeeded > 0f && sNeeded < s)) return;

            float frac = sNeeded / s;

            // compute intermediate speed at the split
            float vMid2 = vNext2 - 2f * aEst * sNeeded;
            float vMid = (vMid2 >= 0f) ? MathF.Sqrt(vMid2) : float.NaN;

            float timePrev = (vMid + vPrev) != 0f ? (s - sNeeded) / ((vMid + vPrev) * 0.5f) : float.PositiveInfinity;
            float timeFinal = (vMid + vNext) != 0f ? sNeeded / ((vMid + vNext) * 0.5f) : float.PositiveInfinity;

            sp.Time[prevIdx] = timePrev;
            sp.Time[finalIdx] = timeFinal;

            sp.DrivingMode[prevIdx] = DrivingMode.Cruise;
            sp.DrivingMode[finalIdx] = sp.DrivingMode[finalIdx]; // keep final (likely Cruise)
        }

        // HandleConnection covers corrections and boundary/impossible handling.
        // Keep it focused: if overshot/impossible we already attempted fractional correction.
        // For unreachable regions we mark a small window NaN to allow higher-level logic to backtrack properly.
        private void HandleConnection(SpeedProfile sp, int i, int offset)
        {
            // simple wrapper for compatibility; treat as neutral if called without flags
            // If you have a version that accepts flags (overshot/impossible), prefer the extended signature
        }

        // Extended HandleConnection invoked from main loops with context
        private void HandleConnection(SpeedProfile sp, int i, int offset, DrivingMode mode,
            bool overshot, bool impossible, bool reachedBoundary)
        {
            // Ensure endpoints remain anchors
            if (sp.Speed.Length >= 1)
            {
                // leave first and last as they were (anchors)
                // nothing to do here if unchanged
            }

            if (impossible)
            {
                // mark a small region NaN so caller can handle by backtracking/resolving boundaries
                int start = Math.Max(0, i - 3);
                int end = Math.Min(sp.Speed.Length - 1, i + 3);
                for (int k = start; k <= end; k++)
                {
                    sp.Speed[k] = float.NaN;
                    sp.Time[k] = float.NaN;
                    sp.Force[k] = float.NaN;
                }
                return;
            }

            if (reachedBoundary)
            {
                // Reached array boundary: keep anchors and let higher-level logic decide how to extend/merge profiles
                return;
            }

            if (overshot)
            {
                // fractional correction already attempted in the loops when we detected clamp/limit.
                // here we ensure no extremely short Transition segments remain:
                // if a DrivingMode appears only for 1 interval and is Transition, we may merge it into adjacent mode
                // Simple heuristic: if a single cell has DrivingMode that differs from both neighbors, set it to neighbor mode
                int idx = i;
                if (idx > 0 && idx < sp.DrivingMode.Length - 1)
                {
                    var left = sp.DrivingMode[idx - 1];
                    var right = sp.DrivingMode[idx + 1];
                    var curMode = sp.DrivingMode[idx];
                    if (curMode != left && curMode != right)
                    {
                        // choose neighbor mode that is not Cruise (prefer actual dynamic modes)
                        if (left != DrivingMode.Cruise) sp.DrivingMode[idx] = left;
                        else sp.DrivingMode[idx] = right;
                    }
                }
            }

            // Normal intersection / no special case: nothing needed here
        }
    }
}
