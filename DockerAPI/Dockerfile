﻿FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["DockerAPI.csproj", "./"]
RUN dotnet restore "DockerAPI.csproj"
COPY . .

FROM build AS publish
RUN dotnet publish "DockerAPI.csproj" -c Release -o /app/publish

FROM base AS final
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "DockerAPI.dll"]