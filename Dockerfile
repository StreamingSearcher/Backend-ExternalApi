FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 3000

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["RelationalMicroservice/RelationalMicroservice.csproj", "RelationalMicroservice/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Domain/Domain.csproj", "Domain/"]
RUN dotnet restore "RelationalMicroservice/RelationalMicroservice.csproj"
COPY . .
WORKDIR /src/RelationalMicroservice
RUN dotnet build "RelationalMicroservice.csproj" -c ${BUILD_CONFIGURATION} -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "RelationalMicroservice.csproj" -c ${BUILD_CONFIGURATION} -o /app/publish

FROM base AS final
WORKDIR /app 
COPY --from=publish /app/publish .



ENTRYPOINT ["dotnet", "RelationalMicroservice.dll"]

# docker run -p 8080:80 -p 8081:3000 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=8081 -e ASPNETCORE_ENVIROMENT=Development -v $env:APPDATA\microsoft\UserSecrets\:/root/.microsoft/usersecrets rm-image
