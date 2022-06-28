# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# Copy csproj and restore as distinct layers
COPY bin/Release/net6.0/publish . 
ENTRYPOINT ["dotnet", "Client.dll"]