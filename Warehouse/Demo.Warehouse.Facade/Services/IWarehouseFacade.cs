namespace Demo.Warehouse.Facade.Services;

public interface IWarehouseFacade
{
    Task CreateWarehouseAsync(CancellationToken cancellationToken = default);
    Task<double> GetAvailabilityAsync(string productId, CancellationToken cancellationToken = default);
}