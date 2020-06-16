# NuGet restore
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY *.sln .
COPY CopaFilmes.Test/*.csproj CopaFilmes.Test/
COPY CopaFilmes.Backend/*.csproj CopaFilmes.Backend/
RUN dotnet restore
COPY . .

# testing
FROM build AS testing
WORKDIR /src/CopaFilmes.Backend
RUN dotnet build
WORKDIR /src/CopaFilmes.Test
RUN dotnet test

# publish
FROM build AS publish
WORKDIR /src/CopaFilmes.Backend
RUN dotnet publish -c Release -o /src/publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime
WORKDIR /app
COPY --from=publish /src/publish .
# ENTRYPOINT ["dotnet", "CopaFilmes.Backend.dll"]
# heroku uses the following
CMD ASPNETCORE_URLS=http://*:$PORT dotnet CopaFilmes.Backend.dll