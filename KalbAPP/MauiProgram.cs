using KalbAPP.ViewModel;
using Microsoft.Extensions.Logging;

namespace KalbAPP;

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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Banana-Stick.otf", "BananaStick");
                fonts.AddFont("Super-Cartoon.ttf", "SuperCartoon");
            });

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddSingleton<GameSettingsPage>();
        builder.Services.AddSingleton<GameSettingsViewModel>();

        builder.Services.AddTransient<GamePage>();
        builder.Services.AddTransient<GameViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}