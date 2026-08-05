using Demo.Warehouse.Facade;
using Demo.Warehouse.Facade.Endpoints;

namespace DemoApi.Modules;

public class WarehouseModule : IModule
{
    public bool IsEnabled => true;
    public int Order => 0;

    public IServiceCollection Register(WebApplicationBuilder builder)
    {
        builder.Services.AddWarehouseCollectionServices();
        return builder.Services;
    }

    public WebApplication Configure(WebApplication app)
    {
        return app.MapWarehouseEndpoints();
    }
}