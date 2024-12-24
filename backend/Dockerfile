# Use the official ASP.NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the official ASP.NET Core SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["HelloWorldApi.csproj", "./"]
RUN dotnet restore "./HelloWorldApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "HelloWorldApi.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "HelloWorldApi.csproj" -c Release -o /app/publish

# Final stage/image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HelloWorldApi.dll"]
