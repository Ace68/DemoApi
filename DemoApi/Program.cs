using DemoApi.Modules;

var builder = WebApplication.CreateBuilder(args);

builder.Register();

var app = builder.Build();

app.Configure();

app.Run();