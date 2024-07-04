using Microsoft.Extensions.Configuration;
using System.Reflection;
using MyTrainingV1311Demo.Core;

namespace MyTrainingV1311Demo.Mobile.MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            ApplicationBootstrapper.InitializeIfNeeds<MyTrainingV1311DemoMobileMAUIModule>();

            var app = builder.Build();
            return app;
        }
    }
}