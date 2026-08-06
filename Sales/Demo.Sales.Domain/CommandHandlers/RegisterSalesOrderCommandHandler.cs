using Demo.Sales.SharedKernel.Messages.Commands;
using Microsoft.Extensions.Logging;
using Muflone.Messages.Commands;
using Muflone.Persistence;

namespace Demo.Sales.Domain.CommandHandlers;

public sealed class RegisterSalesOrderCommandHandler(IRepository repository, ILoggerFactory loggerFactory)
    : CommandHandlerAsync<RegisterSalesOrder>(repository, loggerFactory)
{
    public override Task HandleAsync(RegisterSalesOrder command, CancellationToken cancellationToken = new CancellationToken())
    {
        cancellationToken.ThrowIfCancellationRequested();
        
        return Task.CompletedTask;
    }
}