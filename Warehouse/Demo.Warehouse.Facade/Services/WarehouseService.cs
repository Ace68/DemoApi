namespace Demo.Warehouse.Facade.Services;

public class WarehouseService : IWarehouseService
{
    public Task CreateWarehouseAsync(CancellationToken cancellationToken = default)
    {
        // Implementation here
        return Task.CompletedTask;
    }
}