using BlazorDemo.Hybrid.Wpf.Services;
using BlazorDemo.Hyrbid.Shared.Data;
using BlazorDemo.Hyrbid.Shared.Services;
using BlazorDemo.Hyrbid.Wpf.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace BlazorDemo.Hybrid.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var services = new ServiceCollection();
            services.AddWpfBlazorWebView(); //connecting blazor and
#if DEBUG
            services.AddBlazorWebViewDeveloperTools();
#endif
            services.AddSingleton<IFormFactor, FormFactor>();
            services.AddTransient<IExamService, ExamService>();
            var serviceProvider = services.BuildServiceProvider();

            this.Resources.Add("ServiceProvider", serviceProvider);
        }
    }

}
