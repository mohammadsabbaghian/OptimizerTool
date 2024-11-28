using System;
using System.Threading.Tasks;

namespace TrainCharacteristicsService
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string storageAccountConnectionString = "your_connection_string";
            string tableNameSimple = "TrainUnitParametersSimple";
            string tableName = "TrainUnitParameters";

            AzureTableStorageHelper tableStorageHelper = new AzureTableStorageHelper(storageAccountConnectionString);

            // Create tables
            await tableStorageHelper.CreateTableAsync(tableNameSimple);
            await tableStorageHelper.CreateTableAsync(tableName);

            //// Add entities to TrainUnitParametersSimple table
            //TrainUnitParametersSimple simpleEntity = new TrainUnitParametersSimple
            //{
            //    PartitionKey = "SimplePartition",
            //    RowKey = Guid.NewGuid().ToString(),
            //    ParameterName = "Speed",
            //    ParameterValue = "100"
            //};
            //await tableStorageHelper.AddEntityAsync(tableNameSimple, simpleEntity);

            //// Add entities to TrainUnitParameters table
            //TrainUnitParameters entity = new TrainUnitParameters
            //{
            //    PartitionKey = "ComplexPartition",
            //    RowKey = Guid.NewGuid().ToString(),
            //    ParameterName = "Speed",
            //    ParameterValue = "100",
            //    AdditionalInfo = "Additional information"
            //};
            //await tableStorageHelper.AddEntityAsync(tableName, entity);

            Console.WriteLine("Entities added to Azure Table Storage.");
        }
    }
}