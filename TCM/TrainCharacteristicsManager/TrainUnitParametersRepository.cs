using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public static class TrainUnitParametersRepository
    {
        //Load the parameters from a DB instead
        public static async Task<Dictionary<string, TrainUnitParametersSimple>> GetTrainUnitParametersAsync()
        {
            return new Dictionary<string, TrainUnitParametersSimple>
            {
                ["TGV"] = new TrainUnitParametersSimple
                {
                    Class = "TGV",
                    Type = TrafficType.HighSpeed,
                    BaseClassType = "TGV",
                    CurveRes = 6,
                    TractionPower = 8800,
                    TractionForce= 220,
                    Mass = 380000,
                    Length = 200,
                    DragAmass = 2000,
                    DragA = 2000,
                    DragBmass = 2000,
                    DragB = 2000,
                    DragC = 2000,
                    DeltaDragC = 2000,
                    RotatingMassCoefficient = 1.05f,
                    NumberOfCars = 6
                },
                ["CoradiaStreamHC3"] = new TrainUnitParametersSimple
                {
                    Class = "CoradiaStreamHC3",
                    Type = TrafficType.Regional,
                    BaseClassType = "CoradiaStream",
                    CurveRes = 6,
                    MaxPower = 8800,
                    MaxForce = 220,
                    Mass = 380000,
                    Length = 200,
                    DragAmass = 2000,
                    DragA = 2000,
                    DragBmass = 2000,
                    DragB = 2000,
                    DragC = 2000,
                    DeltaDragC = 2000,
                    RotatingMassCoefficient = 1.043,
                    NumberOfCars = 3

                },
                ["Freight"] = new TrainUnitParametersSimple
                {
                    Class = "Euro4000",
                    Type = TrafficType.Freight,
                    BaseClassType = "Euro4000",
                    CurveRes = 6,
                    MaxPower = 8800000,
                    MaxForce = 420000,
                    Mass = 38000000,
                    Length = 2000,
                    DragAmass = 2000,
                    DragA = 2000,
                    DragBmass = 2000,
                    DragB = 2000,
                    DragC = 2000,
                    DeltaDragC = 2000,
                    RotatingMassCoefficient = 1.05,
                    NumberOfCars = 20
                }
            };
        }
    }
}