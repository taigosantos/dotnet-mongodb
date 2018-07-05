FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY MongoDbTests.Api/MongoDbTests.Api.csproj MongoDbTests.Api/
RUN dotnet restore MongoDbTests.Api/MongoDbTests.Api.csproj
COPY . .
WORKDIR /src/MongoDbTests.Api
RUN dotnet build MongoDbTests.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish MongoDbTests.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MongoDbTests.Api.dll"]
