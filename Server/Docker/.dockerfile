#
#
# STAGE 1: Build
#
#
FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS builder

WORKDIR /Sources
COPY . .

RUN dotnet publish /Sources/IntelPos/IntelPos.csproj --output /app/ --configuration Release

#
#
# STAGE 2: Launch
#
#
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS launcher
WORKDIR /app

COPY --from=builder /app .

ENTRYPOINT ["dotnet", "IntelPos.dll"]