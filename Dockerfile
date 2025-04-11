FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY NFeSPEDAPI/*.csproj ./NFeSPEDAPI/
RUN dotnet restore

# Copy everything else and build
COPY . .
WORKDIR /app/NFeSPEDAPI
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/NFeSPEDAPI/out ./

# Set environment variables
ENV ASPNETCORE_URLS=http://+:80

EXPOSE 80
ENTRYPOINT ["dotnet", "NFeSPEDAPI.dll"]