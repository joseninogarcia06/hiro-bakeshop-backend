# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app
COPY . .

# Restore & publish project
RUN dotnet restore HiroBakeshopBackend/HiroBakeshopBackend.csproj
RUN dotnet publish HiroBakeshopBackend/HiroBakeshopBackend.csproj -c Release -o /app/out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app/out .
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000
ENTRYPOINT ["dotnet", "HiroBakeshopBackend.dll"]