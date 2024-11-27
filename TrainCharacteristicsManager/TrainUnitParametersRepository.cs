using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public static class TrainUnitParametersRepository
    {
        //Load the parameters from a DB instead
        public static async Task<Dictionary<string, TrainUnitParameters>> GetTrainUnitParametersAsync()
        {
            return new Dictionary<string, TrainUnitParameters>
            {
                ["TGV"] = new TrainUnitParameters
                {
                    Class = "TGV",
                    Type = TrafficType.HighSpeed,
                    BaseClassType = "TGV",
                    CurveRes = 6,
                    Power = 8800,
                    Force = 220,
                    Mass = 380000,
                    Length = 200,
                    Amass = 2000,
                    Aaxle = 2000,
                    Bmass = 2000,
                    B = 2000,
                    C = 2000,
                    dC = 2000,
                    RotatingMassCoefficient = 1.05,
                    NumberOfCars = 6
                },
                ["CoradiaStreamHC3"] = new TrainUnitParameters
                {
                    Class = "CoradiaStreamHC3",
                    Type = TrafficType.Regional,
                    BaseClassType = "CoradiaStream",
                    CurveRes = 6,
                    Power = 8800,
                    Force = 220,
                    Mass = 380000,
                    Length = 200,
                    Amass = 2000,
                    Aaxle = 2000,
                    Bmass = 2000,
                    B = 2000,
                    C = 2000,
                    dC = 2000,
                    RotatingMassCoefficient = 1.043,
                    NumberOfCars = 3

                },
                ["Freight"] = new TrainUnitParameters
                {
                    Class = "Euro4000",
                    Type = TrafficType.Freight,
                    BaseClassType = "Euro4000",
                    CurveRes = 6,
                    Power = 8800000,
                    Force = 420000,
                    Mass = 38000000,
                    Length = 2000,
                    Amass = 2000,
                    Aaxle = 2000,
                    Bmass = 2000,
                    B = 2000,
                    C = 2000,
                    dC = 2000,
                    RotatingMassCoefficient = 1.05,
                    NumberOfCars = 20
                }
            };
        }
    }
}