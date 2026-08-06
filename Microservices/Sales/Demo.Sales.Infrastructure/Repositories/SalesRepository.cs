using Muflone;
using Muflone.Core;
using Muflone.Persistence;

namespace Demo.Sales.Infrastructure.Repositories;

public sealed class SalesRepository :IRepository
{
    public void Dispose()
    {
        // TODO release managed resources here
    }

    public Task<TAggregate?> GetByIdAsync<TAggregate>(IDomainId id, CancellationToken cancellationToken = new CancellationToken()) where TAggregate : class, IAggregate
    {
        return Task.FromResult<TAggregate?>(null);
    }

    public Task<TAggregate?> GetByIdAsync<TAggregate>(IDomainId id, long version,
        CancellationToken cancellationToken = new CancellationToken()) where TAggregate : class, IAggregate
    {
        return Task.FromResult<TAggregate?>(null);
    }

    public Task SaveAsync(IAggregate aggregate, Guid commitId, Action<IDictionary<string, object>> updateHeaders,
        CancellationToken cancellationToken = new CancellationToken())
    {
        return Task.CompletedTask;
    }

    public Task SaveAsync(IAggregate aggregate, Guid commitId, CancellationToken cancellationToken = new CancellationToken())
    {
        return Task.CompletedTask;
    }
}