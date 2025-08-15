using Newtonsoft.Json;
using TrainCharacteristicsManager.Models;

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
            var directory = @"source\\OptimizerTestTool\\backend\\src\\resources\\TrainData"; 
            var path = Path.Combine(rootDirectory, directory);
            var files = Directory.GetFiles(path, "*.json");
            foreach (var file in files)
            {
                try
                {
                    var jsonContent = await File.ReadAllTextAsync(file);
                    var tp = JsonConvert.DeserializeObject<TrainUnitParameters>(jsonContent);
                    output.Add(tp.Class, tp);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error processing file {file}: {ex.Message}");
                    // Optionally, set a breakpoint here to inspect the exception
                }
            }

            return output;
        }
    }
}