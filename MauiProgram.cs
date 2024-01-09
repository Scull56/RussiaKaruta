using Microsoft.Extensions.Logging;

namespace RussiaKaruta
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
                    fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                    fonts.AddFont("Roboto-Light.ttf", "RobotoLight");
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoBold");
                });

            builder.Services.AddMauiBlazorWebView();

            #if DEBUG
		            builder.Services.AddBlazorWebViewDeveloperTools();
		            builder.Logging.AddDebug();
            #endif

            return builder.Build();
        }
    }
}