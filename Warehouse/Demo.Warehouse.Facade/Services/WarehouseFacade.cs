namespace Demo.Warehouse.Facade.Services;

public class WarehouseFacade : IWarehouseFacade
{
    public Task CreateWarehouseAsync(CancellationToken cancellationToken = default)
    {
        // Implementation here
        return Task.CompletedTask;
    }

    public Task<double> GetAvailabilityAsync(string productId, CancellationToken cancellationToken = default)
    {
        return Task.FromResult((double)20);
    }
}