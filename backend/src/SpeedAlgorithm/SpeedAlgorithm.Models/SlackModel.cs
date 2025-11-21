namespace SpeedAlgorithm.Models
{
    public class SlackAtTimingPoint
    {
        public int TimingPointId { get; set; }
        public int ProfileIndex { get; set; }   // index in SpeedProfile arrays

        public float Earliest { get; set; }     // s from journey start
        public float Latest { get; set; }     // s from journey start
        public float Arrival { get; set; }     // from profile.Time

        public float SlackEarly => MathF.Max(0f, Earliest - Arrival);
        public float SlackLate => MathF.Max(0f, Latest - Arrival);
    }

    public class SlackScope
    {
        public int StartIndex { get; set; }  // inclusive
        public int EndIndex { get; set; }  // inclusive

        public SlackAtTimingPoint EndTimingPoint { get; set; }

        /// Minimal slack we want to spend before this TP, from this profile.
        public float RequiredSlack { get; set; }

        /// Extra slack possible without being late (if you allow that).
        public float MaxSlack { get; set; }

        public int LengthInIndices => EndIndex - StartIndex + 1;
    }

    public class SlackScopeResult
    {
        public List<SlackAtTimingPoint> TimingPoints { get; } = new();
        public List<SlackScope> Scopes { get; } = new();
    }
}
