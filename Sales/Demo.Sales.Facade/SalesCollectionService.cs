using Demo.Sales.Facade.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Sales.Facade;

public static class SalesCollectionService
{
    public static IServiceCollection AddSalesCollectionServices(this 
        IServiceCollection services)
    {
        services.AddScoped<ISalesOrderService, SalesOrderService>();
        
        return services;
    }
}