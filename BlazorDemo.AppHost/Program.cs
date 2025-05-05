var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorHybridExample_Web>("blazorhybridexample-web");

builder.AddProject<Projects.BlazorWebAppExample>("blazorwebappexample");

builder.Build().Run();
