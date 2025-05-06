using Microsoft.Azure.Cosmos;
using TrainCharacteristicsManager;
using TrainCharacteristicsManager.Models;

namespace TrainCharacteristicsService
{
    public class DatabaseInitializer
    {
        private readonly CosmosClient _cosmosClient;
        private readonly string _databaseId = "TrainCharacteristicsDataBase";
        private readonly string _containerId = "TcDB";

        public DatabaseInitializer(CosmosClient cosmosClient)
        {
            _cosmosClient = cosmosClient;
        }

        public async Task EnsureDatabaseIsPopulatedAsync()
        {
            var database = await _cosmosClient.CreateDatabaseIfNotExistsAsync(_databaseId);
            var container = await database.Database.CreateContainerIfNotExistsAsync(_containerId, "/partitionKey");

            // Populate the database with the latest source files
            var parameters = await TrainUnitParametersRepository.GetTrainUnitParametersAsync();
            foreach (var trainParameters in parameters.Values)
            {
                await container.Container.UpsertItemAsync(trainParameters, new PartitionKey(trainParameters.PartitionKey));
            }
        }
    }
}
