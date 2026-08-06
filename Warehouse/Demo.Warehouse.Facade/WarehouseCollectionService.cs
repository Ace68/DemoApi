using Demo.Warehouse.Facade.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Warehouse.Facade;

public static class WarehouseCollectionService
{
    public static IServiceCollection AddWarehouseCollectionServices(this IServiceCollection services)
    {
        services.AddScoped<IWarehouseFacade, WarehouseFacade>();
        
        return services;
    }
}