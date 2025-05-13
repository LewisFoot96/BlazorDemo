var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorDemo_Hyrbid_Web>("blazordemo-hyrbid-web");

builder.AddProject<Projects.BlazorDemo_Hybrid_WindowsForms>("blazordemo-hybrid-windowsforms");

builder.AddProject<Projects.BlazorDemo_Hybrid_Wpf>("blazordemo-hybrid-wpf");

//builder.AddMobileProject("mauiclient", "../BlazorDemo.Hyrbid");

builder.Build().Run();
