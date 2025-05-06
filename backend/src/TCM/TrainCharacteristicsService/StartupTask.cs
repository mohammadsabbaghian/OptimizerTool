using Microsoft.Extensions.Hosting;

namespace TrainCharacteristicsService
{
    public class StartupTask : IHostedService
    {
        private readonly DatabaseInitializer _databaseInitializer;

        public StartupTask(DatabaseInitializer databaseInitializer)
        {
            _databaseInitializer = databaseInitializer;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _databaseInitializer.EnsureDatabaseIsPopulatedAsync();
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
