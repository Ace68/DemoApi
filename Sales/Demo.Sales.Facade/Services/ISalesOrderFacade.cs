using Demo.Sales.SharedKernel.ExternalContracts;

namespace Demo.Sales.Facade.Services;

public interface ISalesOrderFacade
{
    Task CreateSalesOrderAsync(RegisterOrderJson body, CancellationToken cancellationToken = default);
}