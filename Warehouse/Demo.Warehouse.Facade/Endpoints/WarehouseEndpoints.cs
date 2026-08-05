using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Demo.Warehouse.Facade.Endpoints;

public static class WarehouseEndpoints
{
    public static WebApplication MapWarehouseEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("warehouse")
            .WithTags("Warehouse");
        
        group.MapGet("/", () => "Hello Warehouse!");
        
        return app;
    }
}