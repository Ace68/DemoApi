using Demo.Sales.Domain.CommandHandlers;
using Demo.Sales.SharedKernel.Messages.Commands;
using Microsoft.Extensions.DependencyInjection;
using Muflone;
using Muflone.Messages.Commands;

namespace Demo.Sales.Domain;

public static class DomainServiceCollection
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        // services.AddCommandHandler<RegisterSalesOrderCommandHandler>();
        
        services.AddScoped<ICommandHandlerAsync<RegisterSalesOrder>, RegisterSalesOrderCommandHandler>();
        
        return services;
    }
}