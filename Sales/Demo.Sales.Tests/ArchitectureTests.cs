using System.Diagnostics.CodeAnalysis;
using Demo.Sales.Facade;
using DemoApi.Shared.Tests;
using NetArchTest.Rules;

namespace Demo.Sales.Tests;

[ExcludeFromCodeCoverage]
public class ArchitectureTests
{
    [Fact]
    public void Should_SalesArchitecture_BeCompliant()
    {
        var types = Types.InAssembly(typeof(SalesCollectionService).Assembly);

        var forbiddenAssemblies = TestProjectUtils.GetModuleProjects(false, ["Sales"]);
        
        var result = types
            .ShouldNot()
            .HaveDependencyOnAny(forbiddenAssemblies.ToArray())
            .GetResult()
            .IsSuccessful;

        Assert.True(result);
    }
}