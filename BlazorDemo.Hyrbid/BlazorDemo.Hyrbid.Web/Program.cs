using BlazorDemo.Hyrbid.Shared.Data;
using BlazorDemo.Hyrbid.Shared.Services;
using BlazorDemo.Hyrbid.Web.Components;
using BlazorDemo.Hyrbid.Web.Data;
using BlazorDemo.Hyrbid.Web.Services;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

// Add device-specific services used by the BlazorDemo.Hyrbid.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

builder.Services.AddTransient<IExamService, ExamService>();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(
        typeof(BlazorDemo.Hyrbid.Shared._Imports).Assembly,
        typeof(BlazorDemo.Hyrbid.Web.Client._Imports).Assembly);

app.Run();
