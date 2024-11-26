using SpeedOptimizer.Models.Inputs;

namespace TrainCharacteristicsManager
{
    public static class TrainCharacteristicsRepository
    {
        //Load the parameters from a DB instead
        public static async Task<Dictionary<string, TrainParameters>> GetTrainParametersAsync()
        {
            return new Dictionary<string, TrainParameters>
            {
                ["High-speed"] = new TrainParameters
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
                ["Regional"] = new TrainParameters
                {
                    Class = "Coradia",
                    Type = TrafficType.Regional,
                    BaseClassType = "Coradia",
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
                ["Freight"] = new TrainParameters
                {
                    Class = "Euro4000",
                    Type = TrafficType.Freight,
                    BaseClassType = "Euro4000",
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
                    NumberOfCars = 20
                }
            };
        }
    }
}