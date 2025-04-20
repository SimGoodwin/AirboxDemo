using AirboxDemo.Pages;
using AirboxDemo.Services.Settings;
using AirboxDemo.ViewModels;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace AirboxDemo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .RegisterServices()
                .RegisterViewModels()
                .RegisterViews()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        /// <summary>
        /// Register services for DI
        /// </summary>
        /// <param name="mauiAppBuilder">Builder</param>
        /// <returns>Builder</returns>
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<ISettingsService, SettingsService>();
            mauiAppBuilder.Services.AddTransient<IFileService, FileService>();
            // More services registered here.

            return mauiAppBuilder;
        }

        /// <summary>
        /// Register view models for DI
        /// </summary>
        /// <param name="mauiAppBuilder">Builder</param>
        /// <returns>Builder</returns>
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<PhotoListViewModel>();
            // More view-models registered here.

            return mauiAppBuilder;
        }

        /// <summary>
        /// Register views for DI
        /// </summary>
        /// <param name="mauiAppBuilder">Builder</param>
        /// <returns>Builder</returns>
        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<PhotoListPage>();
            // More views registered here.

            return mauiAppBuilder;
        }
    }
}
