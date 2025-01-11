using tt = Shared.Models.Timetable;

namespace SferaHandlers
{
    internal class JpMapper
    {
        public tt.TimeConstraints Map(JourneyProfile journeyProfile, List<SegmentProfile> segmentProfiles)
        {
            var timeConstraints = new tt.TimeConstraints
            {
                TimingPoints = new List<tt.TimingPoint>()
            };

            foreach (var sp in journeyProfile.SegmentProfileList)
            {
                var spItem = segmentProfiles.FirstOrDefault(x => x.SP_ID == sp.SP_ID);
                if (spItem == null) continue;

                foreach (var timingPoint in sp.TimingPointConstraints)
                {
                    var tp = spItem.SP_Points.TimingPoint.FirstOrDefault(x => x.TP_ID == timingPoint.TimingPointReference.Item);
                    if (tp == null) continue;

                    int.TryParse(timingPoint.arrivalWindow, out var arrivalTolerance);
                    var departureTolerance = 0;

                    if (timingPoint.StoppingPointInformation != null)
                    {
                        var earliestDeparture = timingPoint.StoppingPointInformation.earliestDepartureTime;
                        departureTolerance = (int)(timingPoint.StoppingPointInformation.departureTime - earliestDeparture).TotalSeconds;
                    }
                    
                    var timingPointMapped = new tt.TimingPoint
                    {
                        Name = tp.TP_Name[0].name,
                        Position = tp.location, //LOCATION MUST BE CORRECTED TO BE A LINEAR POSITION
                        StopType = MapStopType(timingPoint.TP_StopSkipPass),
                        ArrivalTime = timingPoint.TP_PlannedLatestArrivalTime,
                        DepartureTime = timingPoint.StoppingPointInformation.departureTime,
                        ArrivalTolerance = arrivalTolerance,
                        DepartureTolerance = departureTolerance
                    };

                    timeConstraints.TimingPoints.Add(timingPointMapped);
                }
            }

            return timeConstraints;
        }

        private Shared.Models.Timetable.StopType MapStopType(NextTimingPointTrainInformationTP_StopSkipPass stopType)
        {
            return stopType switch
            {
                NextTimingPointTrainInformationTP_StopSkipPass.Stopping_Point => Shared.Models.Timetable.StopType.Stop,
                NextTimingPointTrainInformationTP_StopSkipPass.Passing_Point => Shared.Models.Timetable.StopType.DriveThrough,
                NextTimingPointTrainInformationTP_StopSkipPass.Skipped_Stopping_Point => Shared.Models.Timetable.StopType.Push2Stop
            };
        }
    }
}