using MauiMvvm.Models;
using MauiMvvm.ViewModels;
using MauiMvvm.Views;

namespace MauiMvvm;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        _ = builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                _ = fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                _ = fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .RegisterAppServices()
            .RegisterViewModels()
            .RegisterViews()
            .RegisterModels();

        return builder.Build();
    }

    private static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
    {
        _ = mauiAppBuilder.Services.AddSingleton<AppShell>();

        return mauiAppBuilder;
    }

    private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        _ = mauiAppBuilder.Services.AddTransient<MainPageViewModel>();

        return mauiAppBuilder;
    }

    private static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        _ = mauiAppBuilder.Services.AddTransient<MainPage>();

        return mauiAppBuilder;
    }

    private static MauiAppBuilder RegisterModels(this MauiAppBuilder mauiAppBuilder)
    {
        _ = mauiAppBuilder.Services.AddTransient<Item>();

        return mauiAppBuilder;
    }
}
