FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DemoApi/DemoApi.csproj", "DemoApi/"]
COPY ["Sales/Demo.Sales.Facade/Demo.Sales.Facade.csproj", "Sales/Demo.Sales.Facade/"]
COPY ["Sales/Demo.Sales.SharedKernel/Demo.Sales.SharedKernel.csproj", "Sales/Demo.Sales.SharedKernel/"]
COPY ["DemoApi.Shared/DemoApi.Shared.csproj", "DemoApi.Shared/"]
COPY ["Sales/Demo.Sales.Domain/Demo.Sales.Domain.csproj", "Sales/Demo.Sales.Domain/"]
COPY ["Sales/Demo.Sales.Infrastructure/Demo.Sales.Infrastructure.csproj", "Sales/Demo.Sales.Infrastructure/"]
COPY ["Warehouse/Demo.Warehouse.Facade/Demo.Warehouse.Facade.csproj", "Warehouse/Demo.Warehouse.Facade/"]
RUN dotnet restore "DemoApi/DemoApi.csproj"
COPY . .
WORKDIR "/src/DemoApi"
RUN dotnet build "./DemoApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./DemoApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoApi.dll"]
