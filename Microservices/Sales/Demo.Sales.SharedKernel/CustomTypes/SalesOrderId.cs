using Muflone.Core;

namespace Demo.Sales.SharedKernel.CustomTypes;

public sealed class SalesOrderId(string value) : DomainId(value);