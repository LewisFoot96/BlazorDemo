using BlazorDemo.Hyrbid.Data;
using BlazorDemo.Hyrbid.Services;
using BlazorDemo.Hyrbid.Shared.Data;
using BlazorDemo.Hyrbid.Shared.Services;
using Microsoft.Extensions.Logging;

namespace BlazorDemo.Hyrbid
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

            // Add device-specific services used by the BlazorDemo.Hyrbid.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            builder.Services.AddTransient<IExamService, ExamService>();

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
