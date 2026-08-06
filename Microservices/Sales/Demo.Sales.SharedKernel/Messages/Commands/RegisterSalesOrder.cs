using Demo.Sales.SharedKernel.CustomTypes;
using DemoApi.Shared.CustomTypes;
using Muflone.Core;
using Muflone.Messages.Commands;

namespace Demo.Sales.SharedKernel.Messages.Commands;

public class RegisterSalesOrder(SalesOrderId aggregateId, 
    CodiceFiscale codiceFiscale, 
    Guid commitId) : Command(aggregateId, commitId)
{
    public CodiceFiscale CodiceFiscale { get; private set; } = codiceFiscale;
}
