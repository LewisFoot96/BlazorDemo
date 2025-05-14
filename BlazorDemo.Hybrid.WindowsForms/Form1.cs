using BlazorDemo.Hyrbid.Shared;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo.Hybrid.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1(ServiceProvider serviceProvider)
        {
            InitializeComponent();
            blazorWebView1.HostPage = "wwwroot/index.html";
            blazorWebView1.Services = serviceProvider;
            blazorWebView1.RootComponents.Add(new RootComponent("#app", typeof(Routes), null));
        }
    }
}
