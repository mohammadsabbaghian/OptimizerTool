using Shared.Models.Timetable;

namespace SferaHandlers
{
    internal class JpMapper
    {
        public TimeConstraints Map(JourneyProfile journeyProfile, List<SegmentProfile> segmentProfiles)
        {
            var timeConstraints = new TimeConstraints
            {
                TimingPoints = new List<Shared.Models.Timetable.TimingPoint>()
            };

            foreach (var sp in journeyProfile.SegmentProfileList)
            {
                var spItem = segmentProfiles.FirstOrDefault(x => x.SP_ID == sp.SP_ID);
                if (spItem == null) continue;

                foreach (var timingPoint in sp.TimingPointConstraints)
                {
                    var tp = spItem.SP_Points.TimingPoint.FirstOrDefault(x => x.TP_ID == timingPoint.TimingPointReference.Item);
                    if (tp == null) continue;

                    var timingPointMapped = new Shared.Models.Timetable.TimingPoint
                    {
                        Name = tp.TP_Name[0].name,
                        Position = ,
                        StopType = MapStopType(tp.StopType),
                        ArrivalTime = timingPoint.ArrivalTime,
                        DepartureTime = timingPoint.DepartureTime,
                        ArrivalTolerance = timingPoint.ArrivalTolerance,
                        DepartureTolerance = timingPoint.DepartureTolerance
                    };

                    timeConstraints.TimingPoints.Add(timingPointMapped);
                }
            }

            return timeConstraints;
        }

        private StopType MapStopType(string stopType)
        {
            return stopType switch
            {
                "Stop" => StopType.Stop,
                "DriveThrough" => StopType.DriveThrough,
                "Push2Stop" => StopType.Push2Stop,
                _ => StopType.Stop
            };
        }
    }
}