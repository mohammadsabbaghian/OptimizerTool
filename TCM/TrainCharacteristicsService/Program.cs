using Microsoft.Azure.Cosmos;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Net;
using TrainCharacteristics.Models;
using TrainCharacteristicsManager;

namespace TrainCharacteristicsService
{
    class Program
    {
        // The Azure Cosmos DB endpoint for running this sample.
        private static readonly string EndpointUri = ConfigurationManager.AppSettings["EndPointUri"];

        // The primary key for the Azure Cosmos account.
        private static readonly string PrimaryKey = ConfigurationManager.AppSettings["PrimaryKey"];

        // The Cosmos client instance
        private CosmosClient cosmosClient;

        // The database we will create
        private Database database;

        // The container we will create.
        private Microsoft.Azure.Cosmos.Container container;

        private string databaseId = "TrainCharacteristicsDataBase";
        private string containerId = "TcDB";

        static async Task Main(string[] args)
        {

        }

        public async Task GetStartedDemoAsync()
        {
            // Create a new instance of the Cosmos Client
            this.cosmosClient = new CosmosClient(EndpointUri, PrimaryKey, new CosmosClientOptions() { ApplicationName = "TrainCharactersiticsService" });
            await this.CreateDatabaseAsync();
            await this.CreateContainerAndPopulateAsync();


            //await this.ScaleContainerAsync();
            //await this.QueryItemsAsync();
            //await this.ReplaceFamilyItemAsync();
            //await this.DeleteFamilyItemAsync();
            //await this.DeleteDatabaseAndCleanupAsync();
        }
        private async Task CreateDatabaseAsync()
        {
            // Create a new database
            this.database = await this.cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);
            Console.WriteLine("Created Database: {0}\n", this.database.Id);
        }


        private async Task CreateContainerAndPopulateAsync()
        {
            try
            {
                // Attempt to read the container
                this.container = await this.database.GetContainer(containerId).ReadContainerAsync();
                Console.WriteLine("Container '{0}' exists in the database '{1}'.", containerId, databaseId);
                return;
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                Console.WriteLine("Container '{0}' does not exist in the database '{1}'.", containerId, databaseId);
            }

            // Create a new container
            this.container = await this.database.CreateContainerAsync(containerId, "/partitionKey");

            var parameters = TrainUnitParametersRepository.GetTrainUnitParametersAsync().Result;

            foreach (var trainParameters in parameters.Values)
            {
                ItemResponse<TrainUnitParametersSimple> andersenFamilyResponse = await this.container.CreateItemAsync<TrainUnitParametersSimple>(trainParameters, new PartitionKey(trainParameters.PartitionKey));
            }

            Console.WriteLine("Created Container: {0}\n", this.container.Id);
        }

        private async Task ScaleContainerAsync()
        {
            // Read the current throughput
            try
            {
                int? throughput = await this.container.ReadThroughputAsync();
                if (throughput.HasValue)
                {
                    Console.WriteLine("Current provisioned throughput : {0}\n", throughput.Value);
                    int newThroughput = throughput.Value + 100;
                    // Update throughput
                    await this.container.ReplaceThroughputAsync(newThroughput);
                    Console.WriteLine("New provisioned throughput : {0}\n", newThroughput);
                }
            }
            catch (CosmosException cosmosException) when (cosmosException.StatusCode == HttpStatusCode.BadRequest)
            {
                Console.WriteLine("Cannot read container throuthput.");
                Console.WriteLine(cosmosException.ResponseBody);
            }
        }


        private async Task AddItemToContainerAsync(TrainUnitParametersSimple trainParameters)
        {
            try
            {
                ItemResponse<TrainUnitParametersSimple> trainParametersResponse = await this.container.ReadItemAsync<TrainUnitParametersSimple>(trainParameters.Class, new PartitionKey(trainParameters.PartitionKey));
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                ItemResponse<TrainUnitParametersSimple> trainParametersResponse = await this.container.CreateItemAsync<TrainUnitParametersSimple>(trainParameters, new PartitionKey(trainParameters.PartitionKey));
            }
        }

        private async Task AddItemToContainerAsync(TrainUnitParameters trainParameters)
        {
            try
            {
                ItemResponse<TrainUnitParameters> trainParametersResponse = await this.container.ReadItemAsync<TrainUnitParameters>(trainParameters.Class, new PartitionKey(trainParameters.PartitionKey));
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                ItemResponse<TrainUnitParameters> trainParametersResponse = await this.container.CreateItemAsync<TrainUnitParameters>(trainParameters, new PartitionKey(trainParameters.PartitionKey));
            }
        }

        private async Task QueryItemsAsync(string partitionKey = "TrainUnitParametersSimple")
        {
            var sqlQueryText = $@"SELECT * FROM c WHERE c.PartitionKey = '{partitionKey}'";

            Console.WriteLine("Running query: {0}\n", sqlQueryText);

            QueryDefinition queryDefinition = new QueryDefinition(sqlQueryText);
            FeedIterator<TrainUnitParametersSimple> queryResultSetIterator = this.container.GetItemQueryIterator<TrainUnitParametersSimple>(queryDefinition);

            List<TrainUnitParametersSimple> trainParametersList = new List<TrainUnitParametersSimple>();

            while (queryResultSetIterator.HasMoreResults)
            {
                FeedResponse<TrainUnitParametersSimple> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                foreach (TrainUnitParametersSimple trainParameters in currentResultSet)
                {
                    trainParametersList.Add(trainParameters);
                }
            }
        }


    }
}
