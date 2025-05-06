using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Azure.Cosmos;
using Shared.Models.Train;

namespace TrainCharacteristicsService
{
    class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Access configuration
            var configuration = builder.Configuration;

            // Register CosmosClient
            builder.Services.AddSingleton(s =>
            {
                var endpointUri = configuration["EndPointUri"];
                var primaryKey = configuration["PrimaryKey"];
                return new CosmosClient(endpointUri, primaryKey);
            });

            // Register database initializer
            builder.Services.AddSingleton<DatabaseInitializer>();

            // Add minimal API endpoints
            var app = builder.Build();

            app.MapPost("/api/traincharacteristics", async (List<TrainUnit> trainUnits, DatabaseInitializer dbInitializer) =>
            {
                try
                {
                    var parameters = await TrainUnitParametersRepository.GetTrainUnitParametersAsync();
                    var builder = new TrainCharacteristicsBuilder(parameters);
                    var fullCharacteristics = builder.Build(trainUnits);
                    return Results.Ok(fullCharacteristics);
                }
                catch (Exception ex)
                {
                    return Results.Problem($"Internal server error: {ex.Message}");
                }
            });

            app.Run();
        }
    }
}