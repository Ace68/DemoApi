namespace DemoApi.Modules;

public interface IModule
{
    bool IsEnabled { get; }
    IServiceCollection Register(IServiceCollection services);
    WebApplication Configure(WebApplication app);
}