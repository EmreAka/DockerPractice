FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["DockerAPI/DockerAPI.csproj", "DockerAPI/"]
COPY ["Application/Application.csproj", "Application/"]
RUN dotnet restore "DockerAPI/DockerAPI.csproj"
COPY . .

FROM build AS publish
WORKDIR /src/DockerAPI
RUN dotnet publish "DockerAPI.csproj" -c Release -o /app/publish

FROM base AS final
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "DockerAPI.dll"] 