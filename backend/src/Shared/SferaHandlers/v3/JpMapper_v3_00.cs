using tt = Shared.Models.Timetable;
using SFERA_v3_00;

namespace SferaHandlers.v3
{
    public class JpMapper_v3_00
    {
        public tt.TimeConstraints Map(JourneyProfile journeyProfile, SegmentProfile[] segmentProfiles)
        {
            var timeConstraints = new tt.TimeConstraints
            {
                TrainNumber = journeyProfile.TrainIdentification.OTN_ID.teltsi_OperationalTrainNumber,
                TimingPoints = new List<tt.TimingPoint>()
            };

            foreach (var sp in journeyProfile.SegmentProfileReference)
            {
                var spItem = segmentProfiles.FirstOrDefault(x => x.SP_ID == sp.SP_ID);
                if (spItem == null || sp.TimingPointConstraints == null) continue;

                foreach (var timingPoint in sp.TimingPointConstraints)
                {
                    if (timingPoint.TimingPointReference != null && timingPoint.TimingPointReference.Item is TimingPointIdentification_ComplexType tpId)
                    {
                        var tp = spItem.SP_Points.TimingPoint.FirstOrDefault(x => x.TP_ID == tpId.TP_ID);

                        if (tp == null) continue;

                        int.TryParse(timingPoint.arrivalWindow, out var arrivalTolerance);
                        var departureTolerance = 0;

                        if (timingPoint.StoppingPointInformation != null)
                        {
                            var earliestDeparture = timingPoint.StoppingPointDepartureDetails.earliestDepartureTime;
                            departureTolerance = (int)(timingPoint.StoppingPointDepartureDetails.departureTime - earliestDeparture).TotalSeconds;
                        }

                        var timingPointMapped = new tt.TimingPoint
                        {
                            Name = tp.TP_Name[0].name,
                            Position = tp.location, //LOCATION MUST BE CORRECTED TO BE A LINEAR POSITION
                            StopType = MapStopType(timingPoint.TP_StopSkipPass),
                            ArrivalTime = timingPoint.TP_PlannedLatestArrivalTime,
                            ArrivalTolerance = arrivalTolerance,
                            DepartureTolerance = departureTolerance
                        };

                        if (timingPointMapped.IsStop && timingPoint.StoppingPointDepartureDetails!=null)
                            timingPointMapped.DepartureTime = timingPoint.StoppingPointDepartureDetails.departureTime;


                        timeConstraints.TimingPoints.Add(timingPointMapped);
                    }
                }
            }

            return timeConstraints;
        }

        private tt.StopType MapStopType(NextTimingPointTrainInformationTP_StopSkipPass stopType)
        {
            return stopType switch
            {
                NextTimingPointTrainInformationTP_StopSkipPass.Stopping_Point => tt.StopType.Stop,
                NextTimingPointTrainInformationTP_StopSkipPass.Passing_Point => tt.StopType.DriveThrough,
                NextTimingPointTrainInformationTP_StopSkipPass.Skipped_Stopping_Point => tt.StopType.DriveThrough
            };
        }
    }
}