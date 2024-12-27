using Shared.Models.Timetable;

namespace SferaHandlers
{
    internal class JpMapper
    {
        public TimeConstraints Map(ISferaMessage message)
        {
            var timeConstraints = new TimeConstraints();

            return timeConstraints;
        }
    }
}
