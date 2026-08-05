using Demo.Sales.Facade;
using Demo.Sales.Facade.Endpoints;

namespace DemoApi.Modules;

public class SalesModule : IModule
{
    public bool IsEnabled => true;
    public int Order => 0;

    public IServiceCollection Register(WebApplicationBuilder builder)
    {
        builder.Services.AddSalesCollectionServices();
        return builder.Services;
    }

    public WebApplication Configure(WebApplication app) 
        => app.MapSalesEndpoints();
}