using TrainCharacteristicsManager.Models;
using System.Xml;
using Newtonsoft.Json;

namespace TrainCharacteristicsManager
{
    public static class TrainUnitParametersRepository
    {
        //Load the parameters from a DB instead
        public static async Task<Dictionary<string, TrainUnitParameters>> GetTrainUnitParametersAsync()
        {
            var output = new Dictionary<string, TrainUnitParameters>();
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var rootDirectory = Path.GetPathRoot(baseDirectory);
            var directory = @"source\\OptimizerTestTool\\resources\\TrainData";
            var path = Path.Combine(rootDirectory, directory);
            var files = Directory.GetFiles(path, "*.json");
            foreach (var file in files)
            {
                var jsonContent = await File.ReadAllTextAsync(file);
                var tp = JsonConvert.DeserializeObject<TrainUnitParameters>(jsonContent);
                output.Add(tp.Class, tp);
            }

            return output;
        }
    }
}