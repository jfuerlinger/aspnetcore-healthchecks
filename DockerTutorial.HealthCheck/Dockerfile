#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["../DockerTutorial.HealthCheck/DockerTutorial.HealthCheck.csproj", "../DockerTutorial.HealthCheck/"]
RUN dotnet restore "../DockerTutorial.HealthCheck/DockerTutorial.HealthCheck.csproj"
COPY . .
WORKDIR "/src/../DockerTutorial.HealthCheck"
RUN dotnet build "DockerTutorial.HealthCheck.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerTutorial.HealthCheck.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerTutorial.HealthCheck.dll"]