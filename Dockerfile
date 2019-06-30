FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build-env

# Set the working directory to /app
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY . ./
RUN dotnet restore

# build
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/runtime:2.2-alpine

WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "culture-test.dll"]
