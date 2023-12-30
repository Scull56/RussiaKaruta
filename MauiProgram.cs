using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace RussianKaruta
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
				.UseMauiCommunityToolkitMediaElement()
				.ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                    fonts.AddFont("Roboto-Light.ttf", "RobotoLight");
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoBold");
                    fonts.AddFont("YesevaOne-Regular.ttf", "YesevaOne");
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