namespace DemoApi.Shared.Tests;

public static class TestProjectUtils
{
    private static readonly string[] SolutionProjects = [
            "DemoSalesApi.Sales.Domain",
            "DemoSalesApi.Sales.Entities",
            "DemoSalesApi.Sales.Facade",
            "DemoSalesApi.Sales.Infrastructure",
            "DemoSalesApi.Sales.ReadModel", 
            "DemoSalesApi.Sales.SharedKernel",
            "DemoSalesApi.Sales.Tests",
            
            "DemoSalesApi.Warehouse.Domain",
            "DemoSalesApi.Warehouse.Entities",
            "DemoSalesApi.Warehouse.Facade",
            "DemoSalesApi.Warehouse.Infrastructure",
            "DemoSalesApi.Warehouse.ReadModel", 
            "DemoSalesApi.Warehouse.SharedKernel",
            "DemoSalesApi.Warehouse.Tests"
        ];
    
    public static IEnumerable<string> GetModuleProjects(bool includeFacadeProjects, IEnumerable<string> excludeModules)
    {
        return SolutionProjects
            .Where(project =>
                (includeFacadeProjects || !project.EndsWith(".Facade")) &&
                !excludeModules.Any(module => project.StartsWith($"DemoSalesApi.{module}.")));
    }
    
    public static IEnumerable<string> GetModuleProjectsWithoutDomain(string moduleName)
    {
        return SolutionProjects
            .Where(project =>
                project.StartsWith($"DemoSalesApi.{moduleName}") &&
                !project.StartsWith($"DemoSalesApi.{moduleName}.Domain") &&
                !project.StartsWith($"DemoSalesApi.{moduleName}.SharedKernel"));
    }
}