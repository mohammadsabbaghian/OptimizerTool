using TrainCharacteristicsManager.Models;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace TrainCharacteristicsManager
{
    public static class TrainUnitParametersRepository
    {
        //Load the parameters from a DB instead
        public static async Task<Dictionary<string, TrainUnitParameters>> GetTrainUnitParametersAsync()
        {
            var output = new Dictionary<string, TrainUnitParameters>();
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var path = Path.Combine(baseDirectory, "..", "..", "..", "..", "..", "..", "..", "resources", "TrainData");
            Console.WriteLine(path);
            var files = Directory.GetFiles(path, "*.xml");
            foreach (var file in files)
            {
                var tp = LoadFromXml(file);
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
            parameters.DragC = float.Parse(doc.SelectSingleNode("//DragC")?.InnerText ?? "0");
            parameters.Length = float.Parse(doc.SelectSingleNode("//Length")?.InnerText ?? "0");
            parameters.Mass = float.Parse(doc.SelectSingleNode("//Mass")?.InnerText ?? "0");
            parameters.NumberOfCars = int.Parse(doc.SelectSingleNode("//NumCars")?.InnerText ?? "0");
            parameters.MaxSpeed = float.Parse(doc.SelectSingleNode("//MaxSpeed")?.InnerText ?? "0");
            parameters.TractionEfficiency = float.Parse(doc.SelectSingleNode("//TractionEfficiency")?.InnerText ?? "0");
            parameters.BrakingEfficiency = float.Parse(doc.SelectSingleNode("//BrakingEfficiency")?.InnerText ?? "0");
            parameters.TractionCurves = LoadForceCurves(doc.SelectNodes("//TractionCurves/TractionCurves"));
            parameters.TractionCurves = LoadForceCurves(doc.SelectNodes("//ElectricalBrakingCurves/ElectricalBrakingCurve"));
            parameters.BrakingPowerMap = LoadPowerMap(doc.SelectNodes("//TractionPowerMap"));
            parameters.TractionPowerMap = LoadPowerMap(doc.SelectNodes("//brakingPowerMap"));


            return parameters;
        }

        private static PowerMap LoadPowerMap(XmlNodeList? nodes)
        {
            foreach (XmlNode node in nodes)
            {
                var powermapModel = LoadPowerMapArray(node.SelectNodes("Values"));

                var curve = new PowerMap
                {
                    Voltage = int.Parse(node.SelectSingleNode("TractionSystemVoltage")?.InnerText ?? "0"),
                    Frequency = float.Parse(node.SelectSingleNode("TractionSystemFrequency")?.InnerText ?? "0"),
                    Powers = LoadFloatArray(node.SelectNodes("Curve/float"))

                };
                curve.Add(curve);
            }
            return powerMaps;
        }

        private static float[] LoadPowerMap(XmlNodeList nodes)
        {
            var values = new List<float>();
            foreach (XmlNode node in nodes)
            {
                LoadPowerMapArray(node.SelectNodes("Values/ArrayOfFloat"));
                values.Add(float.Parse(node.InnerText));
            }
            return values.ToArray();
        }


        private static float[] LoadPowerMapArray(XmlNodeList nodes)
        {
                        var values = new List<float>();
            foreach (XmlNode node in nodes)
            {
                

                values.Add(float.Parse(node.InnerText));
            }
            return values.ToArray();
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
                    Frequency= float.Parse(node.SelectSingleNode("TractionSystemFrequency")?.InnerText ?? "0"),
                    Forces = LoadFloatArray(node.SelectNodes("Curve/float"))
                };
                forceCurves.Add(curve);
            }
            return forceCurves;
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