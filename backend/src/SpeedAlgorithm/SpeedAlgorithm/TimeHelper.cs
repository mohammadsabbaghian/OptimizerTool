
using Shared.Models.Timetable;
using SpeedAlgorithm.Models;

namespace SpeedAlgorithm
{
    public class TimeHelper
    {
        private TimeConstraints timeConstraints;

        public TimeHelper(TimeConstraints timeConstraints)
        {
            this.timeConstraints = timeConstraints;
        }

        internal List<TimeResult> GetTimeResults(float[] time)
        {
            throw new NotImplementedException();
        }

        internal DateTime ToDateTime(float v)
        {
            throw new NotImplementedException();
        }
    }
}