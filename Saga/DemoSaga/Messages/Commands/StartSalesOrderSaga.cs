using Muflone.Core;
using Muflone.Messages.Commands;

namespace DemoSaga.Messages.Commands;

public sealed class StartSalesOrderSaga(IDomainId aggregateId, Guid commitId) 
    : Command(aggregateId, commitId)
{
    
}