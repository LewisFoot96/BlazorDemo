var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorDemo_Hyrbid_Web>("blazordemo-hyrbid-web");

builder.Build().Run();
