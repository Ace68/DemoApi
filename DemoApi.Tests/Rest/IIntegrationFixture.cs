namespace DemoApi.Tests.Rest;

public interface IIntegrationFixture
{
    TestClient GetClient();
    void ResetAll();
}