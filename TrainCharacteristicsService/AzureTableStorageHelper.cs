using Azure.Data.Tables;

namespace TrainCharacteristicsService
{
    public class AzureTableStorageHelper
    {
        private readonly TableServiceClient _tableServiceClient;

        public AzureTableStorageHelper(string storageAccountConnectionString)
        {
            _tableServiceClient = new TableServiceClient(storageAccountConnectionString);
        }

        public async Task CreateTableAsync(string tableName)
        {
            TableClient tableClient = _tableServiceClient.GetTableClient(tableName);
            await tableClient.CreateIfNotExistsAsync();
        }

        public async Task AddEntityAsync<T>(string tableName, T entity) where T : class, ITableEntity, new()
        {
            TableClient tableClient = _tableServiceClient.GetTableClient(tableName);
            await tableClient.AddEntityAsync(entity);
        }
    }
}