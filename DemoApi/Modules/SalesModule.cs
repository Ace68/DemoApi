using Demo.Sales.Facade;
using Demo.Sales.Facade.Endpoints;

namespace DemoApi.Modules;

public class SalesModule : IModule
{
    public bool IsEnabled => true;

    public IServiceCollection Register(IServiceCollection services)
    {
        services.AddSalesCollectionServices();
        return services;
    }

    public WebApplication Configure(WebApplication app) 
        => app.MapSalesEndpoints();
}