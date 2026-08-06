using Demo.Sales.SharedKernel.CustomTypes;
using Demo.Sales.SharedKernel.ExternalContracts;
using Demo.Sales.SharedKernel.Messages.Commands;
using DemoApi.Shared.CustomTypes;
using Muflone.Messages.Commands;

namespace Demo.Sales.Facade.Services;

internal sealed class SalesOrderFacade(
    ICommandHandlerAsync<RegisterSalesOrder> commandHandler
    ) : ISalesOrderFacade
{
    public async Task CreateSalesOrderAsync(RegisterOrderJson body, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        
        RegisterSalesOrder command = new(new SalesOrderId(Guid.CreateVersion7().ToString()),
            new CodiceFiscale(body.CodiceFiscale), Guid.CreateVersion7());
        
        await commandHandler.HandleAsync(command, cancellationToken);
    }

    public static int Somma(int addendo1, int addendo2)
    {
        return addendo1 + addendo2;
    }

    public static string? FizzBuzz(int i)
    {
        if (i % 3 == 0 &&  i % 5 == 0)
            return "FizzBuzz";
        if (i % 3 == 0)
            return "Fizz";
        if (i % 5 == 0)
            return "Buzz";
        
        return i.ToString();    
    }
}