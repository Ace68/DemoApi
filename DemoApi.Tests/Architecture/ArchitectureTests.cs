using DemoApi.Modules;
using DemoApi.Shared.Tests;
using NetArchTest.Rules;

namespace DemoApi.Tests.Architecture;

public class ArchitectureTests
{
    [Fact]
    public void Should_DemoArchitecture_BeCompliant()
    {
        var types = Types.InAssembly(typeof(IModule).Assembly);

        var forbiddenAssemblies = TestProjectUtils.GetModuleProjects(false, []);
        
        var result = types
            .ShouldNot()
            .HaveDependencyOnAny(forbiddenAssemblies.ToArray())
            .GetResult()
            .IsSuccessful;

        Assert.True(result);
    }
}