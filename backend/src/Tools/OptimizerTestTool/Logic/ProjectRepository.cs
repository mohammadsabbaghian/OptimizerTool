using Shared.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using TrainCharacteristicsManager;

public class ProjectRepository
{
    private readonly string _projectFolder;

    public ProjectRepository()
    {
        _projectFolder = Path.Combine(FileSystem.AppDataDirectory, "Projects");
        Directory.CreateDirectory(_projectFolder);
    }

    public async Task SaveProjectAsync(OptimizerProject project)
    {
        var filePath = Path.Combine(_projectFolder, $"{project.Name}.json");

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var json = JsonSerializer.Serialize(project, options);
        await File.WriteAllTextAsync(filePath, json);
    }

    public void DeleteProjectFile(string projectName)
    {
        var filePath = Path.Combine(_projectFolder, $"{projectName}.json");
        if (File.Exists(filePath))
            File.Delete(filePath);
    }

    public async Task<OptimizerProject> LoadProjectAsync(string name)
    {
        var filePath = Path.Combine(_projectFolder, $"{name}.json");
        var json = await File.ReadAllTextAsync(filePath);

        var options = new JsonSerializerOptions
        {
            Converters = { new JsonStringEnumConverter() },
            PropertyNameCaseInsensitive = true
        };

        var project = JsonSerializer.Deserialize<OptimizerProject>(json, options);

        if (project != null)
        {
            var jsonElement = (JsonElement)project.TrainCharacteristics;

            var modelName = jsonElement.GetProperty("ModelName").GetString();
            try
            {
                if (modelName == "TrainCharacteristicsSimple")
                {
                    project.TrainCharacteristics = JsonSerializer.Deserialize<TrainCharacteristicsSimple>(jsonElement.GetRawText());
                }
                else
                {
                    project.TrainCharacteristics = JsonSerializer.Deserialize<TrainCharacteristics>(jsonElement.GetRawText());

                }
            }
            catch (Exception ex)
            {
            }
            

            switch (project.SferaVersion)
            {
                case "v2.01":
                    project.JourneyProfile = JsonSerializer.Deserialize<SFERA_v2_01.SFERA_G2B_ReplyMessage>(
                        ((JsonElement)project.JourneyProfile).GetRawText());
                    project.SegmentProfiles = JsonSerializer.Deserialize<SFERA_v2_01.SFERA_G2B_ReplyMessage>(
                        ((JsonElement)project.SegmentProfiles).GetRawText());
                    break;
                case "v3.00":
                    project.JourneyProfile = JsonSerializer.Deserialize<SFERA_v3_00.SFERA_G2B_ReplyMessage>(
                        ((JsonElement)project.JourneyProfile).GetRawText());
                    project.SegmentProfiles = JsonSerializer.Deserialize<SFERA_v3_00.SFERA_G2B_ReplyMessage>(
                        ((JsonElement)project.SegmentProfiles).GetRawText());
                    break;
            }
        }
        return project;
    }

    public IEnumerable<string> ListProjects()
    {
        return Directory.EnumerateFiles(_projectFolder, "*.json")
                        .Select(Path.GetFileNameWithoutExtension);
    }
}