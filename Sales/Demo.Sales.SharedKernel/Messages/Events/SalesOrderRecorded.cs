using Demo.Sales.SharedKernel.CustomTypes;
using DemoApi.Shared.CustomTypes;
using Muflone.Core;
using Muflone.Messages.Events;

namespace Demo.Sales.SharedKernel.Messages.Events;

public sealed class SalesOrderRecorded(SalesOrderId aggregateId, 
    CodiceFiscale codiceFiscale, 
    Guid correlationId) : DomainEvent(aggregateId, correlationId)
{
    public CodiceFiscale CodiceFiscale { get; private set; } = codiceFiscale;
}