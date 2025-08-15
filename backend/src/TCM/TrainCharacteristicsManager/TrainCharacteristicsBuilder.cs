using Shared.Models.Train;
using TrainCharacteristicsManager.Models;

namespace TrainCharacteristicsManager
{
    public class TrainCharacteristicsBuilder
    {
        public Dictionary<string, TrainUnitParameters> TrainParameters { get; private set; }

        public TrainCharacteristicsBuilder(Dictionary<string, TrainUnitParameters> trainParameters)
        {
            TrainParameters = trainParameters;
        }
        public TrainCharacteristicsBuilder(){}

        public static async Task<TrainCharacteristicsBuilder> CreateAsync()
        {
            var builder = new TrainCharacteristicsBuilder();
            builder.TrainParameters = await TrainUnitParametersRepository.GetTrainUnitParametersAsync().ConfigureAwait(false);
            return builder;
        }

        public TrainCharacteristicsSimple Build(List<TrainUnit> trainUnits)
        {
            var tc = new TrainCharacteristicsSimple();
            tc.TrainUnits = new List<TrainUnit>();

            SetUnitPositions(trainUnits);

            for (int i = 0; i < trainUnits.Count; i++)
            {
                TrainUnit unit = trainUnits[i];
                tc.TrainUnits.Add(unit);

                var parameters = TrainParameters[unit.Class];
                
                if(unit.TotalMass<=parameters.Mass) 
                    unit.TotalMass = parameters.Mass;

                tc.Mass += unit.TotalMass;
                tc.Length += unit.Length;
                tc.NumberOfCars += parameters.NumberOfCars;
                tc.DragA += parameters.DragA + parameters.DragAmass * unit.TotalMass;
                tc.DragB += parameters.DragB + parameters.DragBmass * unit.TotalMass;

                if (i == 0)
                    tc.DragC += parameters.DragC; 
                tc.DragC += parameters.DeltaDragC;

                tc.BrakingForce += parameters.BrakingForce;
                tc.BrakingPower += parameters.BrakingPower;
                tc.MechanicalBraking += parameters.MechanicalBraking;
                tc.BrakingEfficiency+= parameters.BrakingEfficiency * parameters.BrakingPower;

                if (tc.TractionPower == 0)
                {
                    tc.TractionForce += (int) parameters.TractionCurves[0].Forces.Max();
                    parameters.TractionPower = GetMaxPower(parameters.TractionCurves[0].Forces);
                    tc.TractionPower += parameters.TractionPower;
                }
                else
                {
                    tc.TractionPower += parameters.TractionPower;
                    tc.TractionForce += parameters.TractionForce;
                }
                
                tc.TractionEfficiency += parameters.TractionEfficiency * parameters.TractionPower;
            }
            tc.DragA = tc.DragA / tc.Mass;
            tc.DragB = tc.DragB / tc.Mass;

            tc.TractionEfficiency /= tc.TractionPower;
            
            if(tc.BrakingPower==0)
                tc.BrakingEfficiency = tc.TractionEfficiency;
            else
                tc.BrakingEfficiency /= tc.BrakingPower;



            return tc;
        }

        private int GetMaxPower(float[] forces)
        {
            var powers = new int[forces.Length];
            for (int i = 0; i < forces.Length; i++)
            {
                powers[i] = (int) Math.Round(forces[i] * i / 3.6, 0);
            }
            return powers.Max();
        }

        private void SetUnitPositions(List<TrainUnit> trainUnits)
        {
            if (!trainUnits.Any()) return;

            var end = 0f;
            for (int i = 0; i < trainUnits.Count; i++)
            {
                TrainUnit unit = trainUnits[i];

                //Set unit relative positions
                unit.Start = end;
                end = end + (int)unit.Length;
                unit.End = end;
            }
        }

        public TrainCharacteristicsSimple GetDefaultTrainCharacteristics()
        {
            if (TrainParameters == null || !TrainParameters.Any())
                throw new InvalidOperationException("Train parameters not loaded.");

            var firstType = TrainParameters.Keys.First();
            var param = TrainParameters[firstType];
            var units = new List<TrainUnit>
            {
                new TrainUnit
                {
                    Class = firstType,
                    TotalMass = param.Mass,
                    Length = param.Length,
                    BrakeWeightPercentage = param.BrakedWeightPercentageP,
                    TractionPercentage = 100
                }
            };
            return Build(units);
        }
    }
}
