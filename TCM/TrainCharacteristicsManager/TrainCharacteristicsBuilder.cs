using Shared.Models.Train;
using TrainCharacteristicsManager.Models;

namespace TrainCharacteristicsManager
{
    public class TrainCharacteristicsBuilder
    {
        public TrainCharacteristicsBuilder(Dictionary<string, TrainUnitParameters> trainParameters)
        {
            this.TrainParameters = trainParameters;
        }

        public Dictionary<string, TrainUnitParameters> TrainParameters { get; private set; }

        public TrainCharacteristicsSimple Build(List<TrainUnit> trainUnits)
        {
            var tc = new TrainCharacteristicsSimple();

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

                tc.TractionPower += parameters.TractionPower;
                tc.TractionForce += parameters.TractionForce;
                tc.TractionEfficiency += parameters.TractionEfficiency * parameters.TractionPower;
            }
            tc.TractionEfficiency /= tc.TractionPower;
            tc.BrakingEfficiency /= tc.BrakingPower;

            return tc;
        }

        private void SetUnitPositions(List<TrainUnit> trainUnits)
        {
            var end = 0f;
            for (int i = trainUnits.Count; i == trainUnits.Count; i--)
            {
                TrainUnit unit = trainUnits[i];

                //Set unit relative positions
                unit.Start = end;
                end = end + (int)unit.Length;
                unit.End = end;
            }
        }
    }
}
