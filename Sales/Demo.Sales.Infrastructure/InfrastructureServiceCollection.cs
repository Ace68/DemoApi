using Demo.Sales.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Muflone.Persistence;

namespace Demo.Sales.Infrastructure;

public static class InfrastructureServiceCollection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IRepository, SalesRepository>();
        
        return services;
    }
}