# Use the official Microsoft ASP.NET Core runtime image
# This image includes the .NET runtime and ASP.NET Core
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 8003

# Use the official Microsoft .NET SDK image to build the project
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy the .csproj file and restore any dependencies (via NuGet)
COPY ["testWebApi.csproj", "./"]
RUN dotnet restore "./testWebApi.csproj"

# Copy the project files and build the project
COPY . .
WORKDIR "/src/."
RUN dotnet build "testWebApi.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "testWebApi.csproj" -c Release -o /app/publish

# Final stage/image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "testWebApi.dll"]