#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/MyTrainingV1311Demo.Web.Public/MyTrainingV1311Demo.Web.Public.csproj", "src/MyTrainingV1311Demo.Web.Public/"]
COPY ["src/MyTrainingV1311Demo.Web.Core/MyTrainingV1311Demo.Web.Core.csproj", "src/MyTrainingV1311Demo.Web.Core/"]
COPY ["src/MyTrainingV1311Demo.Application/MyTrainingV1311Demo.Application.csproj", "src/MyTrainingV1311Demo.Application/"]
COPY ["src/MyTrainingV1311Demo.Application.Shared/MyTrainingV1311Demo.Application.Shared.csproj", "src/MyTrainingV1311Demo.Application.Shared/"]
COPY ["src/MyTrainingV1311Demo.Core.Shared/MyTrainingV1311Demo.Core.Shared.csproj", "src/MyTrainingV1311Demo.Core.Shared/"]
COPY ["src/MyTrainingV1311Demo.Core/MyTrainingV1311Demo.Core.csproj", "src/MyTrainingV1311Demo.Core/"]
COPY ["src/MyTrainingV1311Demo.EntityFrameworkCore/MyTrainingV1311Demo.EntityFrameworkCore.csproj", "src/MyTrainingV1311Demo.EntityFrameworkCore/"]
COPY ["src/MyTrainingV1311Demo.GraphQL/MyTrainingV1311Demo.GraphQL.csproj", "src/MyTrainingV1311Demo.GraphQL/"]
RUN dotnet restore "src/MyTrainingV1311Demo.Web.Public/MyTrainingV1311Demo.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/MyTrainingV1311Demo.Web.Public"
RUN dotnet build "MyTrainingV1311Demo.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyTrainingV1311Demo.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyTrainingV1311Demo.Web.Public.dll"]
