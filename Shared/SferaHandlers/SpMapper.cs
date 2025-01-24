using Shared.Models.Route;
using tc = Shared.Models.Train;

namespace SferaHandlers
{
    public class SpMapper
    {

        public RouteConstraints Map(JourneyProfile journeyProfile, SegmentProfile[] segmentProfiles)
        {
            var routeConstraints = new RouteConstraints();

            var spList = journeyProfile.SegmentProfileList;

            var absPos = 0f;

            foreach (var item in spList)
            {
                var sp = segmentProfiles.First(x => x.SP_ID == item.SP_ID);

                // map speed restrictions
                // var srgs = GetSpeedLimits(sp.SP_Characteristics.StaticSpeedProfile, sp.SP_Points.Signal, absPos, (float)sp.SP_Length);
                // routeConstraints.SpeedRestrictionSegments.AddRange(srgs);

                // map the gardient average
                var gradientSegments = GetGradientProfile(sp.SP_Characteristics.GradientAverage, absPos, (float)sp.SP_Length);

                absPos += (float)sp.SP_Length;

            }


            return routeConstraints;
        }

        //Known limitation: train category not considered, nor the ATP system
        private List<SpeedRestrictionSegment> GetSpeedLimits(StaticSpeedProfile[] ssps, Signal_ComplexType[] signals, float absPos, float spLength, string atpId = "")
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

            if (ssp.StaticSpeedProfileChange != null)
            {
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
            }

            srg.End = absPos + spLength;
            srgs.Add(srg);

            return srgs;
        }

        private List<GradientSegment> GetGradientProfile(GradientAverage gradientItem, float absPos, float spLength)
        {
            if (gradientItem.GradientAverageStart == null || gradientItem.GradientAverageChange == null)
            {
                throw new Exception("Gradient data is missing");
            }

            var gradients = new List<GradientSegment>();
            var gradientChanges = gradientItem.GradientAverageChange;

            gradients.Add(new GradientSegment(absPos, absPos + (float)gradientChanges[0].location, (float)gradientItem.GradientAverageStart.gradientValue));

            for (int i = 0; i < gradientChanges.Length; i++)
            {
                var change = gradientChanges[i];
                GradientSegment gradient;

                if (i != gradientChanges.Length - 1)
                {
                    gradient = new GradientSegment(absPos + (float)change.location, absPos + (float)gradientChanges[i + 1].location, (float)change.gradientValue);
                }
                else
                {
                    gradient = new GradientSegment(absPos + (float)change.location, absPos + spLength, (float)change.gradientValue);
                }
                gradients.Add(gradient);
            }
            return gradients;
        }
    }
}
