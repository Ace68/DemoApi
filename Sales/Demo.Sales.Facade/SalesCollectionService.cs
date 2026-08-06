using Demo.Sales.Domain;
using Demo.Sales.Facade.Services;
using Demo.Sales.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Muflone;

namespace Demo.Sales.Facade;

public static class SalesCollectionService
{
    public static IServiceCollection AddSalesCollectionServices(this 
        IServiceCollection services)
    {
        services.AddScoped<ISalesOrderFacade, SalesOrderFacade>();

        services.AddDomain();
        services.AddInfrastructure();
        
        return services;
    }
}