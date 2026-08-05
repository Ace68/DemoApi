namespace Demo.Sales.Facade.Services;

public interface ISalesOrderService
{
    Task CreateSalesOrderAsync(CancellationToken cancellationToken = default);
}