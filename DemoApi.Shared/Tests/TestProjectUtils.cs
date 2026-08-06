namespace DemoApi.Shared.Tests;

public static class TestProjectUtils
{
    private static readonly string[] SolutionProjects = [
            "DemoApi.Sales.Domain",
            "DemoApi.Sales.Entities",
            "DemoApi.Sales.Facade",
            "DemoApi.Sales.Infrastructure",
            "DemoApi.Sales.ReadModel", 
            "DemoApi.Sales.SharedKernel",
            "DemoApi.Sales.Tests",
            
            "DemoApi.Warehouse.Domain",
            "DemoApi.Warehouse.Entities",
            "DemoApi.Warehouse.Facade",
            "DemoApi.Warehouse.Infrastructure",
            "DemoApi.Warehouse.ReadModel", 
            "DemoApi.Warehouse.SharedKernel",
            "DemoApi.Warehouse.Tests"
        ];
    
    public static IEnumerable<string> GetModuleProjects(bool includeFacadeProjects, IEnumerable<string> excludeModules)
    {
        return SolutionProjects
            .Where(project =>
                (includeFacadeProjects || !project.EndsWith(".Facade")) &&
                !excludeModules.Any(module => project.StartsWith($"DemoApi.{module}.")));
    }
    
    public static IEnumerable<string> GetModuleProjectsWithoutDomain(string moduleName)
    {
        return SolutionProjects
            .Where(project =>
                project.StartsWith($"DemoApi.{moduleName}") &&
                !project.StartsWith($"DemoApi.{moduleName}.Domain") &&
                !project.StartsWith($"DemoApi.{moduleName}.SharedKernel"));
    }
}