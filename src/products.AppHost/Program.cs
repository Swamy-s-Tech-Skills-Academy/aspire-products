var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.products_ApiService>("apiservice");

builder.AddProject<Projects.products_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
