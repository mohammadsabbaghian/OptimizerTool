
using Shared.Models;
using SpeedAlgorithm.Models;

namespace SpeedOptimizer.Helpers
{
    /// <summary>
    /// A single "option": apply a specific strategy on [RegionStartIndex..RegionEndIndex].
    /// Holds a local subprofile slice (pooled), impact metrics, and a local weight.
    /// Lower Weight is better.
    /// </summary>
    public sealed class Region : IDisposable
    {
        private static int _idCounter;

        public int Id { get; private set; }

        /// <summary>
        /// Number of times this region has been modified/refined.
        /// </summary>
        public int ModifiedCount { get; set; }

        /// <summary>
        /// Debug: ID of component/iteration that last modified this region.
        /// </summary>
        public int LastModifiedBy { get; set; }

        /// <summary>
        /// Indices in the full SpeedProfile where this region logically spans.
        /// </summary>
        public int RegionStartIndex { get; set; }
        public int RegionEndIndex { get; set; }

        /// <summary>
        /// Indices actually recomputed/optimized inside this region.
        /// Often equal to region start/end, but can be a subrange.
        /// </summary>
        public int OptimizedFromIndex { get; set; }
        public int OptimizedToIndex { get; set; }

        /// <summary>
        /// Strategy to be applied in this region (LowerCruise, ExtendCoast, etc.).
        /// </summary>
        public Strategy Strategy { get; set; }

        /// <summary>
        /// Id of the main timing point affected by this region (if any).
        /// </summary>
        public int? AffectedTimingPointId { get; set; }

        /// <summary>
        /// Other regions that interact with this one (overlapping indices, same TP, etc.).
        /// </summary>
        public List<Region> LinkedRegions { get; } = new();

        /// <summary>
        /// Energy impact vs baseline over the optimized range:
        /// EnergyImpact = E_baseline - E_region_with_strategy.
        /// So EnergyImpact > 0 means energy saved.
        /// </summary>
        public double EnergyImpact { get; private set; }

        /// <summary>
        /// Time impact vs baseline over the optimized range:
        /// TimeImpact = T_baseline - T_region_with_strategy.
        /// So TimeImpact < 0 means we use more time (slower).
        /// </summary>
        public double TimeImpact { get; private set; }

        /// <summary>
        /// Local ranking metric; lower is better.
        /// This is *not* the global objective, just a local efficiency indicator.
        /// </summary>
        public double Weight { get; private set; }

        /// <summary>
        /// True if region is currently considered usable.
        /// </summary>
        public bool IsFeasible { get; private set; } = true;

        /// <summary>
        /// Whether this region should be re-evaluated in next iteration.
        /// </summary>
        public bool CalculateNext { get; set; } = true;

        /// <summary>
        /// Optional local subprofile slice for [OptimizedFromIndex..OptimizedToIndex].
        /// Backed by SpeedProfilePool.
        /// </summary>
        public SpeedProfile? PartialProfile { get; private set; }

        public Region()
        {
            Id = System.Threading.Interlocked.Increment(ref _idCounter);
        }

        public Region(
            Strategy strategy,
            int regionStart,
            int regionEnd,
            int optimizedFrom,
            int optimizedTo) : this()
        {
            Strategy = strategy;
            RegionStartIndex = regionStart;
            RegionEndIndex = regionEnd;
            OptimizedFromIndex = optimizedFrom;
            OptimizedToIndex = optimizedTo;
        }

        public void Reset(
            Strategy strategy,
            int regionStart,
            int regionEnd,
            int optimizedFrom,
            int optimizedTo)
        {
            Id = System.Threading.Interlocked.Increment(ref _idCounter);

            Strategy = strategy;
            RegionStartIndex = regionStart;
            RegionEndIndex = regionEnd;
            OptimizedFromIndex = optimizedFrom;
            OptimizedToIndex = optimizedTo;

            ModifiedCount = 0;
            LastModifiedBy = 0;
            CalculateNext = true;
            IsFeasible = true;

            EnergyImpact = 0;
            TimeImpact = 0;
            Weight = 0;

            ReleaseLocalSlice();
            LinkedRegions.Clear();
        }

        /// <summary>
        /// Rent a local slice for this region from SpeedProfilePool.
        /// Caller must fill it via dynamics.
        /// </summary>
        public void AllocateLocalSlice(int length)
        {
            ReleaseLocalSlice(); // in case there was one
            PartialProfile = SpeedProfilePool.Rent(length);
        }

        public void ReleaseLocalSlice()
        {
            if (PartialProfile != null)
            {
                SpeedProfilePool.Return(PartialProfile.Value);
                PartialProfile = null;
            }
        }

        public void SetInfeasible()
        {
            ReleaseLocalSlice();
            CalculateNext = false;
            IsFeasible = false;
        }

        /// <summary>
        /// Compute EnergyImpact and TimeImpact by comparing baseline profile
        /// and PartialProfile over [OptimizedFromIndex..OptimizedToIndex].
        /// 
        /// Assumes:
        /// - PartialProfile.Length == (OptimizedToIndex - OptimizedFromIndex + 1)
        /// - both share the same physical positions / step length
        /// </summary>
        public void SetImpactSameLength(SpeedProfile baseline)
        {
            if (!IsFeasible || PartialProfile == null)
                return;

            var partialProfile = PartialProfile.Value;

            int expectedLength = OptimizedToIndex - OptimizedFromIndex + 1;
            if (PartialProfile.Value.Speed.Length != expectedLength)
            {
                SetInfeasible();
                return;
            }

            double oT = 0.0;
            double nT = 0.0;
            double oE = 0.0;
            double nE = 0.0;

            for (int i = 0; i < expectedLength; i++)
            {
                int globalIndex = OptimizedFromIndex + i;
                float vOld = baseline.Speed[globalIndex];
                float vNew = partialProfile.Speed[i];

                // If speeds are essentially identical, skip this index.
                if (Math.Abs(vOld - vNew) < 0.001f)
                    continue;

                oT += baseline.Time[globalIndex];
                nT += partialProfile.Time[i];

                oE += baseline.Energy[globalIndex];
                nE += partialProfile.Energy[i];
            }

            TimeImpact = oT - nT;
            EnergyImpact = oE - nE;

            // No change -> region is useless
            if (Math.Abs(TimeImpact) < 1e-6 && Math.Abs(EnergyImpact) < 1e-6)
            {
                SetInfeasible();
            }
            else
            {
                IsFeasible = true;
            }
        }

        /// <summary>
        /// Check coasting constraint on the PartialProfile: every coast run must be at least minCoastIntervals long.
        /// </summary>
        public bool FulfillsCoastingConstraint(int minCoastIntervals)
        {
            if (!IsFeasible || PartialProfile == null || PartialProfile.Value.Speed.Length == 0)
                return true;

            var partialProfile = PartialProfile.Value;


            int minLength = int.MaxValue;
            int length = 1;

            for (int i = 1; i < partialProfile.Length; i++)
            {
                if (partialProfile.DrivingMode[i - 1] == DrivingMode.Coast &&
                    partialProfile.DrivingMode[i] == DrivingMode.Coast)
                {
                    length++;
                }
                else
                {
                    if (length != 1 && length < minLength)
                        minLength = length;
                    length = 1;
                }
            }

            if (minLength == int.MaxValue)
                return true; // no coast at all

            return minLength >= minCoastIntervals;
        }

        /// <summary>
        /// Compute a local ranking Weight based solely on TimeImpact and EnergyImpact.
        /// Lower Weight is better.
        /// This does NOT use slack; slack is handled when combining regions.
        /// 
        /// Convention:
        /// EnergyImpact = E_baseline - E_region  (>0 = energy saved)
        /// TimeImpact   = T_baseline - T_region  (<0 = slower, more time used)
        /// </summary>
        public void CalculateWeight()
        {
            const double eps = 1e-6;
            double w;

            if (EnergyImpact > eps)
            {
                // We save energy
                if (TimeImpact < -eps)
                {
                    // Slower, saves energy: efficiency = energySaved / extraTime
                    double efficiency = EnergyImpact / (-TimeImpact); // >0
                    w = -efficiency; // more efficient => more negative => better
                }
                else if (Math.Abs(TimeImpact) <= eps)
                {
                    // Same time, saves energy: ideal case
                    w = -1e6 * EnergyImpact;
                }
                else // TimeImpact > 0
                {
                    // Faster and saves energy: possible due to dynamics,
                    // but keep it moderately attractive, not infinite.
                    w = -0.1 * EnergyImpact;
                }
            }
            else if (EnergyImpact < -eps)
            {
                // We spend extra energy -> strongly disfavoured
                if (TimeImpact < -eps)
                {
                    // Slower and more energy = terrible
                    w = 1e6;
                }
                else if (TimeImpact > eps)
                {
                    // Faster but more energy. Maybe useful for feasibility,
                    // but from energy perspective it's bad.
                    double ratio = (-EnergyImpact) / TimeImpact;
                    w = 1e3 * ratio;
                }
                else
                {
                    // Same time, worse energy
                    w = 1e6;
                }
            }
            else
            {
                // No energy change, pure time effect
                if (TimeImpact < -eps)
                {
                    // Just slower, no energy gain: slightly bad
                    w = 100 * (-TimeImpact);
                }
                else if (TimeImpact > eps)
                {
                    // Just faster, no energy change: mildly positive
                    w = 10 * TimeImpact;
                }
                else
                {
                    // No difference at all
                    w = 0;
                }
            }

            // Optional: slight bias in favour of coast-related strategies
            if (Strategy == Strategy.Coast)
            {
                w *= 0.9;
            }

            Weight = w;
        }

        public override string ToString()
        {
            const int unitConversion = 3600;
            return $"Id: {Id}; F: {IsFeasible}; Strgy: {Strategy}; " +
                   $"From: {OptimizedFromIndex}; To: {OptimizedToIndex}; " +
                   $"Mod#: {ModifiedCount}; ModBy: {LastModifiedBy}; " +
                   $"W: {Math.Round(Weight / unitConversion, 3)}; " +
                   $"TI: {Math.Round(TimeImpact, 3)}; " +
                   $"EI: {Math.Floor(EnergyImpact / unitConversion)}";
        }

        public void Dispose()
        {
            ReleaseLocalSlice();
            LinkedRegions.Clear();
        }
    }
}
