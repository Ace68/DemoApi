FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DemoSalesApi/DemoSalesApi.csproj", "DemoSalesApi/"]
COPY ["Sales/Demo.Sales.Facade/Demo.Sales.Facade.csproj", "Sales/Demo.Sales.Facade/"]
COPY ["Sales/Demo.Sales.Domain/Demo.Sales.Domain.csproj", "Sales/Demo.Sales.Domain/"]
COPY ["Sales/Demo.Sales.SharedKernel/Demo.Sales.SharedKernel.csproj", "Sales/Demo.Sales.SharedKernel/"]
COPY ["Sales/Demo.Sales.Tests/Demo.Sales.Tests.csproj", "Sales/Demo.Sales.Tests/"]
COPY ["Sales/Demo.Sales.Infrastructure/Demo.Sales.Infrastructure.csproj", "Sales/Demo.Sales.Infrastructure/"]
COPY ["DemoApi.Shared/DemoApi.Shared.csproj", "DemoApi.Shared/"]
COPY ["../Monitor/Demo.Host.Services/Demo.Host.Services.csproj", "../Monitor/Demo.Host.Services/"]

RUN dotnet restore "DemoSalesApi/DemoSalesApi.csproj"

RUN dotnet test "Sales/Demo.Sales.Tests/Demo.Sales.Tests.csproj"

COPY . .
WORKDIR "/src/DemoSalesApi"
RUN dotnet build "./DemoSalesApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./DemoSalesApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoSalesApi.dll"]
