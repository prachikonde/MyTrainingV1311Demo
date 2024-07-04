#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/MyTrainingV1311Demo.Migrator/MyTrainingV1311Demo.Migrator.csproj", "src/MyTrainingV1311Demo.Migrator/"]
COPY ["src/MyTrainingV1311Demo.EntityFrameworkCore/MyTrainingV1311Demo.EntityFrameworkCore.csproj", "src/MyTrainingV1311Demo.EntityFrameworkCore/"]
COPY ["src/MyTrainingV1311Demo.Core/MyTrainingV1311Demo.Core.csproj", "src/MyTrainingV1311Demo.Core/"]
COPY ["src/MyTrainingV1311Demo.Core.Shared/MyTrainingV1311Demo.Core.Shared.csproj", "src/MyTrainingV1311Demo.Core.Shared/"]
RUN dotnet restore "src/MyTrainingV1311Demo.Migrator/MyTrainingV1311Demo.Migrator.csproj"
COPY . .
WORKDIR "/src/src/MyTrainingV1311Demo.Migrator"
RUN dotnet build "MyTrainingV1311Demo.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyTrainingV1311Demo.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyTrainingV1311Demo.Migrator.dll", "-s"]
