using Newtonsoft.Json;
using System.Xml;
using TrainCharacteristicsManager.Models;

namespace Resources
{
    public class xmlMapper
    {

        public static async Task<Dictionary<string, TrainUnitParameters>> GetTrainUnitParametersAsync()
        {
            var output = new Dictionary<string, TrainUnitParameters>();
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var rootDirectory = Path.GetPathRoot(baseDirectory);
            var directory = @"D:\Git\Core.Algorithm\src\TrainCharacteristics\Algorithm.TrainCharacteristics.Resources\TrainCharacteristics";
            var path = Path.Combine(rootDirectory, directory);
            Console.WriteLine(path);
            var files = Directory.GetFiles(path, "*.xml");
            foreach (var file in files)
            {
                var tp = LoadFromXml(file);
                SerializeToJson(tp, file.Replace(".xml", ".json"));
                output.Add(tp.Class, tp);
            }

            return output;
        }
        public static TrainUnitParameters LoadFromXml(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            TrainUnitParameters parameters = new TrainUnitParameters();

            parameters.BaseClassType = doc.SelectSingleNode("//BaseTrainType")?.InnerText;
            parameters.Class = doc.SelectSingleNode("//TrainClassId")?.InnerText;
            parameters.DeltaDragC = float.Parse(doc.SelectSingleNode("//DeltaDragC")?.InnerText ?? "0");
            parameters.DragA = float.Parse(doc.SelectSingleNode("//DragAaxle")?.InnerText ?? "0");
            parameters.DragAmass = float.Parse(doc.SelectSingleNode("//DragAmass")?.InnerText ?? "0");
            parameters.DragB = float.Parse(doc.SelectSingleNode("//DragB")?.InnerText ?? "0");
            parameters.DragBmass = float.Parse(doc.SelectSingleNode("//DragBmass")?.InnerText ?? "0");
            parameters.DragC = float.Parse(doc.SelectSingleNode("//DragC")?.InnerText ?? "0");
            parameters.Length = float.Parse(doc.SelectSingleNode("//Length")?.InnerText ?? "0");
            parameters.Mass = float.Parse(doc.SelectSingleNode("//Mass")?.InnerText ?? "0");
            parameters.NumberOfCars = int.Parse(doc.SelectSingleNode("//NumCars")?.InnerText ?? "0");
            parameters.MaxSpeed = float.Parse(doc.SelectSingleNode("//MaxSpeed")?.InnerText ?? "0");
            parameters.TractionEfficiency = float.Parse(doc.SelectSingleNode("//TractionEfficiency")?.InnerText ?? "0");
            parameters.BrakingEfficiency = float.Parse(doc.SelectSingleNode("//RegenerationEfficiency")?.InnerText ?? "0");
            parameters.TractionForce = int.Parse(doc.SelectSingleNode("//MaxForce")?.InnerText ?? "0");
            parameters.TractionPower = int.Parse(doc.SelectSingleNode("//MaxPower")?.InnerText ?? "0");
            parameters.MechanicalBraking = float.Parse(doc.SelectSingleNode("//MechanicalBraking")?.InnerText ?? "0");
            parameters.RotatingMassCoefficient = float.Parse(doc.SelectSingleNode("//RotatingMassCoefficient")?.InnerText ?? "0");

            parameters.TractionCurves = LoadForceCurves(doc.SelectNodes("//TractionCurves/TractionCurve"));
            parameters.BrakingCurves = LoadForceCurves(doc.SelectNodes("//ElectricalBrakingCurves/ElectricalBrakingCurve"));
            parameters.TractionPowerMap = LoadPowerMap(doc.SelectSingleNode("//TractionPowerMap/Values"));
            parameters.BrakingPowerMap = LoadPowerMap(doc.SelectSingleNode("//ElectricalBrakingPowerMap/Values"));
            parameters.PreferedBraking = LoadPreferedBraking(doc.SelectSingleNode("//StepwisePreferredDecelerationRate"));

            parameters.BrakedWeightPercentageG = int.Parse(doc.SelectSingleNode("//BrakedWeightPercentageG")?.InnerText ?? "0");
            parameters.BrakedWeightPercentageP = int.Parse(doc.SelectSingleNode("//BrakedWeightPercentageP")?.InnerText ?? "0");
            parameters.DisplayName = doc.SelectSingleNode("//Caption")?.InnerText;
            parameters.Propulsion = bool.Parse(doc.SelectSingleNode("//IsAffectedByPowerRestriction")?.InnerText ?? "false") ?
                Shared.Models.Train.Propulsion.Electric : Shared.Models.Train.Propulsion.SelfPropelled;
            parameters.NumAxles = int.Parse(doc.SelectSingleNode("//NumAxles")?.InnerText ?? "0");
            parameters.SupportedTypes = LoadSupportedTypes(doc.SelectNodes("//SupportedTypes/string"));
            parameters.MinimumCoastingSpeed = float.Parse(doc.SelectSingleNode("//MinimumCoastingSpeed")?.InnerText ?? "0");
            parameters.MinimumCoastingDistance = int.Parse(doc.SelectSingleNode("//MinimumCoastingDistance")?.InnerText ?? "0");
            parameters.IsLoco = bool.Parse(doc.SelectSingleNode("//IsLoco")?.InnerText ?? "false");
            parameters.SpeedometerDeviation = float.Parse(doc.SelectSingleNode("//SpeedometerDeviation")?.InnerText ?? "0");

            parameters.BrakingForce = float.Parse(doc.SelectSingleNode("//MaximumElectricBrakeForce")?.InnerText ?? "0");
            parameters.TractionEfficiency = 0.8f;
            parameters.BrakingEfficiency = float.Parse(doc.SelectSingleNode("//RegenerationEfficiency")?.InnerText ?? "0.8");

            return parameters;
        }

        public static void SerializeToJson(TrainUnitParameters parameters, string filePath)
        {
            var jsonFilePath = Path.ChangeExtension(filePath, ".json");
            var jsonString = JsonConvert.SerializeObject(parameters, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonString);
        }

        private static float[,] LoadPreferedBraking(XmlNode? node)
        {
            if (node == null)
            {
                var values = new float[1, 2];
                values[0, 0] = 0;
                values[0, 1] = 0.6f;
                return values;
            }
            else
            {
                var nodes = node.SelectNodes("//DecelerationRate");
                var values = new float[nodes.Count, 2];

                for (int i = 0; i < nodes.Count; i++)
                {
                    values[i, 0] = float.Parse(nodes[i].SelectSingleNode("ChangeV")?.InnerText ?? "0");
                    values[i, 1] = float.Parse(nodes[i].SelectSingleNode("Value")?.InnerText ?? "0");
                }

                return values;
            }

        }

        public static PowerMap LoadPowerMap(XmlNode node)
        {
            if (node == null) return null;

            var tractionPercentages = new float[0];
            var speeds = new List<float>();
            var values = new List<int[]>();

            var nodes = node.SelectNodes("ArrayOfFloat");

            for (int i = 0; i < nodes.Count; i++)
            {
                var row = LoadFloatArray(nodes[i].SelectNodes("float"));
                if (i == 0)
                {
                    // First row contains traction percentages
                    tractionPercentages = row.Skip(1).ToArray();
                }
                else
                {
                    // First element of each row is the speed value
                    speeds.Add(row[0]);
                    // The rest are the values of the multidimensional array
                    values.Add(row.Skip(1).Select(v => (int)v).ToArray());
                }
            }

            // Convert the list of values to a multidimensional array
            var valuesArray = new int[values.Count, tractionPercentages.Length];
            for (int i = 0; i < values.Count; i++)
            {
                for (int j = 0; j < tractionPercentages.Length; j++)
                {
                    valuesArray[i, j] = values[i][j];
                }
            }

            return new PowerMap(valuesArray, speeds.ToArray(), tractionPercentages);
        }

        private static List<ForceCurve> LoadForceCurves(XmlNodeList nodes)
        {
            var forceCurves = new List<ForceCurve>();
            foreach (XmlNode node in nodes)
            {
                var curve = new ForceCurve
                {
                    IsMax = bool.Parse(node.SelectSingleNode("IsMax")?.InnerText ?? "false"),
                    Voltage = int.Parse(node.SelectSingleNode("TractionSystemVoltage")?.InnerText ?? "0"),
                    Frequency = float.Parse(node.SelectSingleNode("TractionSystemFrequency")?.InnerText ?? "0"),
                    Forces = LoadFloatArray(node.SelectNodes("Curve/float"))
                };
                forceCurves.Add(curve);
            }
            return forceCurves;
        }
        private static List<string> LoadSupportedTypes(XmlNodeList nodes)
        {
            var supportedTypes = new List<string>();
            foreach (XmlNode node in nodes)
            {
                supportedTypes.Add(node.InnerText);
            }
            return supportedTypes;
        }
        private static float[] LoadFloatArray(XmlNodeList nodes)
        {
            var values = new List<float>();
            foreach (XmlNode node in nodes)
            {
                values.Add(float.Parse(node.InnerText));
            }
            return values.ToArray();
        }
    }
}
