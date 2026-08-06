using DemoSaga.Messages.Commands;
using Muflone.Messages.Commands;
using Muflone.Persistence;

namespace DemoSaga;

public sealed class SalesOrderOrchestrator(IServiceBus serviceBus) :
    ICommandHandlerAsync<StartSalesOrderSaga>
{
    public Task HandleAsync(StartSalesOrderSaga message, CancellationToken cancellationToken = new CancellationToken())
    {
        // .... 
        return Task.CompletedTask;
    }
    
    #region Dispose

    private void Dispose(bool disposing)
    {
        if (disposing)
        {
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~SalesOrderOrchestrator()
    {
        Dispose(false);
    }

    #endregion
}