using SpeedOptimizer.Helpers;
using Shared.Models;
using SpeedAlgorithm.Models;
using TrainCharacteristicsManager;

namespace SpeedAlgorithm.Helpers
{
    public sealed class RegionFinder : IRegionFinder
    {
        // Small numeric tolerances
        private const float SpeedEpsilon = 0.1f;
        private const float ForceEpsilon = 0.1f;

        public List<Region> FindRegions(
            SpeedProfile profile,
            SlackScopeResult slackResult,
            TrainCharacteristics train,
            AlgorithmConfiguration config)
        {
            var regions = new List<Region>();

            if (slackResult.Scopes.Count == 0)
                return regions;

            // Scopes should already be sorted by length (largest first) by SlackScopeAnalyzer,
            // which aligns with your "operate on large areas first" requirement.
            foreach (var scope in slackResult.Scopes)
            {
                int start = scope.StartIndex;
                int end = scope.EndIndex;

                if (end <= start || end >= profile.Speed.Length)
                    continue;

                // 1. Cruise strategy (lowering / reshaping cruise in this large scope)
                var cruiseRegion = DetectCruiseRegion(profile, start, end);
                if (cruiseRegion != null)
                {
                    cruiseRegion.AffectedTimingPointId = scope.EndTimingPoint?.TimingPointId;
                    regions.Add(cruiseRegion);
                }

                // 2. ExtendCoast strategy for existing coasts
                regions.AddRange(
                    DetectExtendCoastRegions(profile, start, end, scope));

                // 3. Coast strategy around maintain segments (Cruise/CruiseDecelerate with braking)
                regions.AddRange(
                    DetectInsertCoastRegions(profile, start, end, scope));
            }

            return regions;
        }

        #region Cruise (lowering / reshaping cruise in a scope)

        /// <summary>
        /// Detect whether there is a speed-up-then-slow-down pattern in [start..end].
        /// If yes, we create a single Cruise region over the entire scope.
        /// This region will be used later to lower cruise speed / smooth the top.
        /// </summary>
        private Region? DetectCruiseRegion(
            SpeedProfile profile,
            int start,
            int end)
        {
            var speed = profile.Speed;
            bool sawUp = false;
            bool sawDown = false;

            for (int i = start + 1; i <= end; i++)
            {
                float dv = speed[i] - speed[i - 1];

                if (dv > SpeedEpsilon)
                {
                    sawUp = true;
                }
                else if (dv < -SpeedEpsilon && sawUp)
                {
                    sawDown = true;
                    break;
                }
            }

            if (!sawUp || !sawDown)
            {
                // no clear "accelerate then decelerate" pattern; skip Cruise strategy for this scope
                return null;
            }

            var region = new Region(
                Strategy.Cruise,
                regionStart: start,
                regionEnd: end,
                optimizedFrom: start,
                optimizedTo: end);

            return region;
        }

        #endregion

        #region ExtendCoast (existing coast blocks)

        /// <summary>
        /// Find all existing DrivingMode.Coast blocks in [start..end] and
        /// create ExtendCoast regions anchored on those blocks.
        /// The region spans the full scope, but OptimizedFrom/To focus on the coast block.
        /// </summary>
        private IEnumerable<Region> DetectExtendCoastRegions(
            SpeedProfile profile,
            int start,
            int end,
            SlackScope scope)
        {
            var result = new List<Region>();
            var modes = profile.DrivingMode;

            int blockStart = -1;

            for (int i = start; i <= end; i++)
            {
                if (modes[i] == DrivingMode.Coast)
                {
                    if (blockStart < 0)
                        blockStart = i;
                }
                else
                {
                    if (blockStart >= 0)
                    {
                        int blockEnd = i - 1;
                        AddExtendCoastRegionIfLongEnough(
                            result, blockStart, blockEnd, start, end, scope);
                        blockStart = -1;
                    }
                }
            }

            // tail block
            if (blockStart >= 0)
            {
                int blockEnd = end;
                AddExtendCoastRegionIfLongEnough(
                    result, blockStart, blockEnd, start, end, scope);
            }

            return result;
        }

        private void AddExtendCoastRegionIfLongEnough(
            List<Region> list,
            int blockStart,
            int blockEnd,
            int scopeStart,
            int scopeEnd,
            SlackScope scope)
        {
            int length = blockEnd - blockStart + 1;

            // minimal length check; the exact threshold should ideally use AlgorithmConfiguration.
            // For now, simple guard to avoid 1-interval coast noise:
            const int MinCoastBlockIntervals = 2;
            if (length < MinCoastBlockIntervals)
                return;

            var region = new Region(
                Strategy.Coast,
                regionStart: scopeStart,
                regionEnd: scopeEnd,
                optimizedFrom: blockStart,
                optimizedTo: blockEnd)
            {
                AffectedTimingPointId = scope.EndTimingPoint?.TimingPointId
            };

            list.Add(region);
        }

        #endregion

        #region Coast (insert/reshape coast around maintain segments)

        /// <summary>
        /// Detect regions where we are maintaining speed with braking (Cruise/CruiseDecelerate + negative Force).
        /// Those are good candidates to insert or reshape coasting instead of "maintain with brake".
        /// </summary>
        private IEnumerable<Region> DetectInsertCoastRegions(
            SpeedProfile profile,
            int start,
            int end,
            SlackScope scope)
        {
            var result = new List<Region>();
            var modes = profile.DrivingMode;
            var force = profile.Force;

            int blockStart = -1;

            bool IsMaintainWithBrake(int idx)
            {
                var mode = modes[idx];
                if (mode != DrivingMode.Cruise && mode != DrivingMode.CruiseDecelerate)
                    return false;

                // Negative force => braking to hold speed
                return force[idx] < -ForceEpsilon;
            }

            for (int i = start; i <= end; i++)
            {
                if (IsMaintainWithBrake(i))
                {
                    if (blockStart < 0)
                        blockStart = i;
                }
                else
                {
                    if (blockStart >= 0)
                    {
                        int blockEnd = i - 1;
                        AddCoastRegionForMaintainBlock(result, blockStart, blockEnd, start, end, scope);
                        blockStart = -1;
                    }
                }
            }

            if (blockStart >= 0)
            {
                int blockEnd = end;
                AddCoastRegionForMaintainBlock(result, blockStart, blockEnd, start, end, scope);
            }

            return result;
        }

        private void AddCoastRegionForMaintainBlock(
            List<Region> list,
            int blockStart,
            int blockEnd,
            int scopeStart,
            int scopeEnd,
            SlackScope scope)
        {
            int length = blockEnd - blockStart + 1;
            if (length <= 0)
                return;

            // We can later refine where exactly to start/stop coasting.
            // For now, we anchor the optimization on this maintain block,
            // but allow the region to span the whole scope.
            var region = new Region(
                Strategy.Coast,
                regionStart: scopeStart,
                regionEnd: scopeEnd,
                optimizedFrom: blockStart,
                optimizedTo: blockEnd)
            {
                AffectedTimingPointId = scope.EndTimingPoint?.TimingPointId
            };

            list.Add(region);
        }

        #endregion
    }
}
