namespace Demo.Warehouse.Facade.Services;

public interface IWarehouseService
{
    Task CreateWarehouseAsync(CancellationToken cancellationToken = default);
}