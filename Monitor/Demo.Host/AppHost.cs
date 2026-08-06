using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var salesApi = builder.AddContainer("demosalesapi", "demosalesapi")
    .WithHttpEndpoint(
        name: "http",
        port: 8081,
        targetPort: 8080);

builder.AddProject<DemoApi>("DemoApi")
    .WaitFor(salesApi);

builder.Build().Run();