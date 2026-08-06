using Demo.Sales.Facade.Services;
using Demo.Sales.SharedKernel.ExternalContracts;
using DemoApi.Shared.CustomTypes;
using DemoApi.Shared.Validation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Demo.Sales.Facade.Endpoints;

public static class SalesEndpoints
{
    public static WebApplication MapSalesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("sales")
            .WithTags("Sales");
        
        group.MapPost("", RegisterSalesOrderAsync)
            .AddEndpointFilter<ValidationFilter<RegisterOrderJson>>()
            .Produces(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status500InternalServerError)
            .WithSummary("Register a new sales order")
            .WithDescription(
                "Registers a new sales order. This endpoint is used to add a new sales order.")
            .WithName("RegisterSalesOrder");
        
        group.MapGet("", 
            async (ISalesOrderFacade salesOrderService, CancellationToken cancellationToken) =>
        {
            // Implement logic to retrieve sales orders
            return Results.Ok("HelloSales!");
        });

        return app;
    }
    
    private static async Task<IResult> RegisterSalesOrderAsync(
        ISalesOrderFacade salesOrderService, 
        RegisterOrderJson body,
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        
        await salesOrderService.CreateSalesOrderAsync(body, cancellationToken);
        return Results.Ok();
    }
}