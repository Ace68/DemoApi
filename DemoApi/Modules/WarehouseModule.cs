using Demo.Warehouse.Facade;
using Demo.Warehouse.Facade.Endpoints;

namespace DemoApi.Modules;

public class WarehouseModule : IModule
{
    public bool IsEnabled => true;

    public IServiceCollection Register(IServiceCollection services)
    {
        services.AddWarehouseCollectionServices();
        return services;
    }

    public WebApplication Configure(WebApplication app)
    {
        return app.MapWarehouseEndpoints();
    }
}