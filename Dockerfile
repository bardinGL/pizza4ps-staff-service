FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy and restore
COPY ["src/Pizza4Ps.StaffService.API/Pizza4Ps.StaffService.API.csproj", "src/Pizza4Ps.StaffService.API/"]
RUN dotnet restore "src/Pizza4Ps.StaffService.API/Pizza4Ps.StaffService.API.csproj"

# Copy the rest of the files and build
COPY . .
WORKDIR "src/Pizza4Ps.StaffService.API"
RUN dotnet build "Pizza4Ps.StaffService.API.csproj" -c Release -o /app/build

# Publish
RUN dotnet publish "Pizza4Ps.StaffService.API.csproj" -c Release -o /app/publish

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Development
ENTRYPOINT ["dotnet", "Pizza4Ps.StaffService.API.dll"]
