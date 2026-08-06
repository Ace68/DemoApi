using System.Net;

namespace DemoApi.Tests.Rest.Sales;

[Collection("Integration Fixture")]
public sealed class SalesModuleTests(IntegrationFixture integrationFixture) : IDisposable
{
     [Fact]
     public async Task Get_Sales()
     {
         var result = await integrationFixture.Client.GetAsync("/sales");

         Assert.Equal(HttpStatusCode.OK, result.StatusCode);

         Assert.NotEqual("HelloSales!", await result.Content.ReadAsStringAsync());
     }
     
     #region Dispose

     public void Dispose()
     {
         integrationFixture.ResetAll();
     }

     #endregion
}