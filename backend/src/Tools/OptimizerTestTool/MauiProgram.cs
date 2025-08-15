using OptimizerTestTool.Pages;
using OptimizerTestTool.Services;
using Syncfusion.Maui.Core.Hosting;
using TrainCharacteristicsManager;

namespace OptimizerTestTool
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSansRegular.ttf", "OpenSansRegular");
                });

            // Register services/pages as usual
            builder.Services.AddSingleton<TrainCharacteristicsBuilderProvider>();
            builder.Services.AddSingleton<TrainCharacteristicsBuilder>();
            builder.Services.AddSingleton<CalculationRepository>();
            builder.Services.AddSingleton<ConsistBuilderPage>();
            builder.Services.AddSingleton<SettingsPage>();
            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}