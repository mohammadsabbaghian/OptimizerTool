using Shared.Models.Route;
using tc = Shared.Models.Train;

namespace SferaHandlers
{
    internal class SpMapper
    {
        
        public RouteConstraints Map(JourneyProfile journeyProfile, List<SegmentProfile> segmentProfiles)
        {
            var routeConstraints = new RouteConstraints();

            var spList = journeyProfile.SegmentProfileList;

            var absPos = 0;
            foreach (var item in spList)
            {
                var sp = segmentProfiles.First(x => x.SP_ID == item.SP_ID);
                var srgs = GetSpeedLimits(sp.SP_Characteristics.StaticSpeedProfile, absPos, (float)sp.SP_Length);
            }

            return routeConstraints;
        }

        //Known limitation: train category not considered, nor the ATP system
        private List<SpeedRestrictionSegment> GetSpeedLimits(StaticSpeedProfile[] ssps, float absPos, float spLength, string atpId = "")
        {
            var srgs = new List<SpeedRestrictionSegment>();
            var ssp = string.IsNullOrEmpty(atpId) || ssps.Length == 1
                ? ssps[0]
                : ssps.FirstOrDefault(x => x.ATP_System_Identifier.Any(id => id.Value == atpId)) ?? ssps[0];

            var srg = new SpeedRestrictionSegment
            {
                Start = absPos,
                Speed = (float)ssp.StaticSpeedProfileStart.SSP_Speed
            };

            foreach (var change in ssp.StaticSpeedProfileChange)
            {
                srg.End = absPos + (float)change.location;
                srgs.Add(srg);

                srg = new SpeedRestrictionSegment
                {
                    Start = absPos + (float)change.location,
                    Speed = (float)change.SSP_Speed
                };
            }

            srg.End = absPos + spLength;
            srgs.Add(srg);

            return srgs;
        }
    }
}
