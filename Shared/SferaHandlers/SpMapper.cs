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

                var srgs = GetSpeedLimits(sp.SP_Characteristics.StaticSpeedProfile, sp.SP_Points.Signal, absPos, (float)sp.SP_Length);
                routeConstraints.SpeedRestrictionSegments.AddRange(srgs);

                var gradientSegments = GetGradientProfile(sp.SP_Characteristics.GradientAverage, absPos, (float)sp.SP_Length);
                routeConstraints.GradientSegments.AddRange(gradientSegments);

                var curveSegments = GetCurveProfile(sp.SP_Characteristics.Curves, absPos, (float)sp.SP_Length);
                routeConstraints.Curves.AddRange(curveSegments);

                if (sp.SP_Areas != null)
                {
                    var tunnelSegments = GetTunnelSegments(sp.SP_Areas.Tunnel, absPos, (float)sp.SP_Length);
                    routeConstraints.Tunnels.AddRange(tunnelSegments);
                }
                var segmentPositions = GetSegmentPositions(sp.SP_Points.VirtualBalise, absPos);
                routeConstraints.Points.AddRange(segmentPositions);

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

        private static List<GradientSegment> GetGradientProfile(GradientAverage gradientItem, float absPos, float spLength)
        {
            if (gradientItem == null || gradientItem.GradientAverageStart == null || gradientItem.GradientAverageChange == null)
            {
                return new List<GradientSegment>();
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

        private static List<CurveSegment> GetCurveProfile(Curves curveItem, float absPos, float spLength)
        {
            if (curveItem == null)
            {
                return new List<CurveSegment>();
            }

            if (curveItem.CurveStart == null || curveItem.CurveChange == null)
            {
                throw new Exception("Curve data is missing");
            }

            var curves = new List<CurveSegment>();
            var curveChanges = curveItem.CurveChange;

            curves.Add(new CurveSegment(absPos, absPos + (float)curveChanges[0].location, (float)curveItem.CurveStart.curveRadius));

            for (int i = 0; i < curveChanges.Length; i++)
            {
                var change = curveChanges[i];
                CurveSegment curve;
                if (i != curveChanges.Length - 1)
                {
                    curve = new CurveSegment(absPos + (float)change.location, absPos + (float)curveChanges[i + 1].location, (float)change.curveRadius);
                }
                else
                {
                    curve = new CurveSegment(absPos + (float)change.location, absPos + spLength, (float)change.curveRadius);
                }
                curves.Add(curve);
            }
            return curves;
        }

        private static List<TunnelSegment> GetTunnelSegments(Tunnel[] tunnels, float absPos, float spLength)
        {
            if (tunnels == null)
            {
                return new List<TunnelSegment>();
            }
            var tunnelSegments = new List<TunnelSegment>();
            foreach (var tunnel in tunnels)
            {
                tunnelSegments.Add(new TunnelSegment(absPos + (float)tunnel.startLocation, absPos + (float)tunnel.endLocation, (float)tunnel.tunnelFactor));
            }
            return tunnelSegments;
        }

        private static List<SegmentPosition> GetSegmentPositions(VirtualBalise[] vbs, float absPos)
        {
            if (vbs == null || vbs.Length == 0)
            {
                return new List<SegmentPosition>();
            }
            var segmentPositions = new List<SegmentPosition>();
            foreach (var vb in vbs)
            {
                var kmReference = vb.identifier ?? string.Empty;
                // also add latitude and longitude?
                segmentPositions.Add(new SegmentPosition(position: absPos + vb.location, kmReference: kmReference, altitude: (float)vb.VirtualBalisePosition.altitude));
            }
            return segmentPositions;
        }
    }
}
