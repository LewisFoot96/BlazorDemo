using BlazorDemo.Hybrid.WindowsForms.Data;
using BlazorDemo.Hybrid.WindowsForms.Services;
using BlazorDemo.Hyrbid.Shared.Data;
using BlazorDemo.Hyrbid.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo.Hybrid.WindowsForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView(); //connecting blazor and
#if DEBUG
            services.AddBlazorWebViewDeveloperTools();
#endif
            services.AddSingleton<IFormFactor, FormFactor>();
            services.AddTransient<IExamService, ExamService>();
            var serviceProvider = services.BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}