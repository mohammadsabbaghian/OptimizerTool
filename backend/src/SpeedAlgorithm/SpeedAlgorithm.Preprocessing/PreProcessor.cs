using Shared.Models.Route;
using Shared.Models.Timetable;
using SpeedAlgorithm.Models;
using TrainCharacteristicsManager;
using System;
using System.Collections.Generic;

namespace SpeedAlgorithm.Preprocessing
{
    public class PreProcessor
    {
        private RouteConstraints _routeConstraints;
        private ITrainCharacteristics _trainCharacteristics;
        private TimeConstraints _timeConstraints;

        public int InitialNumberOfIntervals => 2500;
        public int MinimumDiscretisationInterval => 1;
        public int MaximumDiscretisationInterval => 20;

        public Constraints Process(TimeConstraints timeConstraints, RouteConstraints routeConstraints, ITrainCharacteristics trainCharacteristics)
        {
            _routeConstraints = routeConstraints;
            _trainCharacteristics = trainCharacteristics;
            _timeConstraints = timeConstraints;

            var numberOfDiscInterval = GetNumberOfDiscretizationIntervals(routeConstraints.Length);
            var discInterval = GetDiscretizationInterval(routeConstraints.Length, numberOfDiscInterval);

            if (routeConstraints.GradientSegments == null)
            {
                if (routeConstraints.Points != null && routeConstraints.Points.Any(x => x.Altitude.HasValue))
                    routeConstraints.GradientSegments = GradientHelper.GetGradientSegments(routeConstraints.Points);
                else
                    routeConstraints.GradientSegments = new List<GradientSegment>() { new GradientSegment(routeConstraints.Start, routeConstraints.End, 0f) };
            }

            if (routeConstraints.Curves != null && routeConstraints.Curves.Count > 0)
            {
                var curveHelper = new CurveHelper(trainCharacteristics.CurveRes);
                routeConstraints.GradientSegments = curveHelper.MergeSegments(routeConstraints.Curves, routeConstraints.GradientSegments);
            }

            if (routeConstraints.Tunnels != null && routeConstraints.Tunnels.Count > 0)
            {
                var tunnelHelper = new TunnelHelper(trainCharacteristics.FrontalArea);
                routeConstraints.Tunnels = tunnelHelper.CalculateTunnelFactor(routeConstraints.Tunnels);
            }

            var forceLimitationHandler = new ForceLimitationsHandler(routeConstraints, trainCharacteristics);
            var forceCurve = forceLimitationHandler.GetForceCurves(0);

            var weighedGradients = GradientHelper.GetWeightedAverageGradientArray(routeConstraints.GradientSegments, discInterval, trainCharacteristics.TrainUnits);

            var constraints = new Constraints(numberOfDiscInterval, discInterval);

            // Pre-create arrays and default curve indices
            constraints.TractionCurveIndices = new int[numberOfDiscInterval];
            constraints.BrakingCurveIndices = new int[numberOfDiscInterval];

            // Precompute passage point indices (rounded and clamped)
            var passagePointIndices = new int[timeConstraints.TimingPoints.Count];
            for (int p = 0; p < timeConstraints.TimingPoints.Count; p++)
            {
                var relPos = timeConstraints.TimingPoints[p].Position - routeConstraints.Start;
                var idx = (int)Math.Round(relPos / discInterval);
                idx = Math.Max(0, Math.Min(numberOfDiscInterval - 1, idx));
                passagePointIndices[p] = idx;
            }

            // Walk through speed restriction segments and tunnels once
            var speedSegs = _routeConstraints.SpeedRestrictionSegments;
            int speedSegIdx = 0;
            var lastSpeedSeg = speedSegs[speedSegs.Count - 1];

            var tunnels = _routeConstraints.Tunnels ?? new List<TunnelSegment>();
            int tunnelIdx = 0;

            for (int i = 0; i < numberOfDiscInterval; i++)
            {
                var position = routeConstraints.Start + (i + 1) * discInterval; // matches original advancing position

                // Speed limit lookup: advance pointer until the segment contains position or we passed it
                while (speedSegIdx < speedSegs.Count && speedSegs[speedSegIdx].End < position) speedSegIdx++;
                if (speedSegIdx >= speedSegs.Count) constraints.SpeedLimits[i] = lastSpeedSeg.Speed;
                else
                {
                    var seg = speedSegs[speedSegIdx];
                    if (seg.Start <= position && seg.End >= position) constraints.SpeedLimits[i] = seg.Speed;
                    else constraints.SpeedLimits[i] = lastSpeedSeg.Speed;
                }

                // Track resistance from weighted gradients (already in same length)
                constraints.Trackresistances[i] = (float)weighedGradients[i] * 9.81f;

                // Tunnel factor: advance pointer
                while (tunnelIdx < tunnels.Count && tunnels[tunnelIdx].End < position) tunnelIdx++;
                constraints.TunnelFactors[i] = (tunnelIdx < tunnels.Count && tunnels[tunnelIdx].Start <= position && tunnels[tunnelIdx].End >= position)
                    ? tunnels[tunnelIdx].TunnelFactor
                    : 1f;

                // Passage point: find earliest passage point index >= i
                var pp = Array.Find(passagePointIndices, x => x >= i);
                constraints.PassagePointIndices[i] = pp;

                // Default curve indices: if forceCurve gives per-interval mapping, use it; else default 0
                constraints.TractionCurveIndices[i] = 0;
                constraints.BrakingCurveIndices[i] = 0;
            }

            return constraints;
        }

        private int GetNumberOfDiscretizationIntervals(float totalDistance)
        {
            var discInterval = Math.Min(Math.Max(totalDistance / InitialNumberOfIntervals, MinimumDiscretisationInterval), MaximumDiscretisationInterval);
            return (int)Math.Ceiling(totalDistance / discInterval);
        }
        private int GetDiscretizationInterval(float totalDistance, int numberOfIntervals)
        {
            return (int)Math.Round(totalDistance / numberOfIntervals);
        }
    }
}
