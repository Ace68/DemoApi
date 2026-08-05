using Demo.Sales.Facade.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Demo.Sales.Facade.Endpoints;

public static class SalesEndpoints
{
    public static WebApplication MapSalesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("sales")
            .WithTags("Sales");
        
        group.MapPost("", 
            async (ISalesOrderService salesOrderService, CancellationToken cancellationToken) =>
        {
            await salesOrderService.CreateSalesOrderAsync(cancellationToken);
            return Results.Ok();
        });
        
        group.MapGet("", 
            async (ISalesOrderService salesOrderService, CancellationToken cancellationToken) =>
        {
            // Implement logic to retrieve sales orders
            return Results.Ok(new { Message = "Retrieve sales orders not implemented yet." });
        });

        return app;
    }
}