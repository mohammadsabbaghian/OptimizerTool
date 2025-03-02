using Shared.Models.Route;
using tc = Shared.Models.Train;

namespace SferaHandlers
{
    public class SpMapper
    {
        private TrainCharacteristics _trainCharacteristics;

        public RouteConstraints Map(JourneyProfile journeyProfile, SegmentProfile[] segmentProfiles, TrainCharacteristics trainCharacteristics)
        {
            _trainCharacteristics = trainCharacteristics;
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

                var signalSpeedLimits = GetSignalSpeedLimits(sp.SP_Points.Signal, absPos, (float)sp.SP_Length);
                routeConstraints.SpeedRestrictionSegments.AddRange(signalSpeedLimits);

                var temporarySpeeds = GetTemporarySpeeds(item.TemporaryConstraints, absPos);
                routeConstraints.SpeedRestrictionSegments.AddRange(temporarySpeeds);

                var adhesionSegments = GetAdhesionLimits(item.TemporaryConstraints, absPos);
                routeConstraints.AdhesionSegments.AddRange(adhesionSegments);

                var powerConstraints = GetPowerConstraints(sp, absPos);
                routeConstraints.PowerSegments.AddRange(powerConstraints);

                absPos += (float)sp.SP_Length;
            }
            return routeConstraints;
        }


        //TODO: inaccurate.
        private List<PowerLimitSegment> GetPowerConstraints(SegmentProfile sp, float absPos)
        {
            var powerSegments = new List<PowerLimitSegment>();
            var ratedVChange = sp.SP_Characteristics.RatedVoltage.RatedVoltageChange;
            var ratedVoltage = sp.SP_Characteristics.RatedVoltage.RatedVoltageStart?.voltageValue;
            if (ratedVoltage == null)
                ratedVoltage = 25000;

            // Map Neutral Sections
            if (sp.SP_Characteristics.CurrentLimitation != null)
            {
                var cl = sp.SP_Characteristics.CurrentLimitation;
                var segment = new PowerLimitSegment
                {
                    Start = absPos ,
                    End = absPos,
                    PowerLimit = (float)(cl.CurrentLimitationStart.maxCurValue * ratedVoltage)
                };

                for (int i = 0; i < sp.SP_Characteristics.CurrentLimitation.CurrentLimitationChange.Length; i++)
                {
                    var clc = sp.SP_Characteristics.CurrentLimitation.CurrentLimitationChange[i];
                    segment.End +=  (float)clc.location;
                    powerSegments.Add(segment);
                    if(ratedVChange!=null)
                        ratedVoltage = sp.SP_Characteristics.RatedVoltage.RatedVoltageChange.LastOrDefault(x => x.location < clc.location)?.voltageValue;
                    segment = new PowerLimitSegment
                    {
                        Start = absPos + (float)clc.location,
                        End = absPos + (float)clc.,
                        PowerLimit = (float)(clc.maxCurValue * ratedVoltage)
                    };
                }
                segment.End = absPos + (float)sp.SP_Length;
                powerSegments.Add(segment);

            }

            return powerSegments;
        }
        private List<SpeedRestrictionSegment> GetSignalSpeedLimits(Signal_ComplexType[] signals, float absPos, float spLength)
        {
            var srgs = new List<SpeedRestrictionSegment>();
            foreach (var signal in signals)
            {
                if (signal.SignalInformation.Item is MaxSpeed maxSpeed)
                {
                    var srg = new SpeedRestrictionSegment
                    {
                        Start = absPos + (float)signal.SignalApplication.StartSignalApplication.location,
                        End = absPos + (float)signal.SignalApplication.EndSignalApplication.location,
                        Speed = (float)maxSpeed.speed
                    };
                    srgs.Add(srg);
                }
            }
            return srgs;
        }

        private List<SpeedRestrictionSegment> GetTemporarySpeeds(TemporaryConstraints[] temporaryConstraints, float absPos)
        {
            var srgs = new List<SpeedRestrictionSegment>();
            foreach (var tc in temporaryConstraints)
            {
                if (tc.temporaryConstraintType == TemporaryConstraintsTemporaryConstraintType.ASR)
                {
                    foreach (var asr in tc.Items)
                    {
                        var item = (AdditionalSpeedRestriction)asr;

                        var offset = item.ASR_Front ? 0f : _trainCharacteristics.Length;
                        var srg = new SpeedRestrictionSegment
                        {
                            Start = absPos + (float)tc.startLocation,
                            End = absPos + (float)tc.endLocation + offset,
                            Speed = (float)item.ASR_Speed
                        };
                        srgs.Add(srg);
                    }
                }
            }
            return srgs;
        }

        private List<AdhesionLimitationSegment> GetAdhesionLimits(TemporaryConstraints[] temporaryConstraints, float absPos)
        {
            var las = new List<AdhesionLimitationSegment>();
            foreach (var tc in temporaryConstraints)
            {
                if (tc.temporaryConstraintType == TemporaryConstraintsTemporaryConstraintType.Low_Adhesion)
                {
                    foreach (var la in tc.Items)
                    {
                        var item = (LowAdhesion)la;
                        var srg = new AdhesionLimitationSegment
                        {
                            Start = absPos + (float)tc.startLocation,
                            End = absPos + (float)tc.endLocation,
                            Adhesion = (float)MapAdhesionCategory(item.lowAdhesionCategory)
                        };
                        las.Add(srg);
                    }
                }
            }
            return las;
        }

        private float MapAdhesionCategory(adhesionCategoryType lowAdhesionCategory)
        {
            switch (lowAdhesionCategory)
            {
                case adhesionCategoryType.ExtremelyLowAdhesion:
                    return 0.25f;
                case adhesionCategoryType.VeryLowAdhesion:
                    return 0.40f;
                case adhesionCategoryType.LowAdhesion:
                    return 0.55f;
                case adhesionCategoryType.DryRailLow:
                    return 0.7f;
                case adhesionCategoryType.DryRailMedium:
                    return 0.85f;
                case adhesionCategoryType.DryRail:
                    return 1f;
            }
            return 1f;
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
 