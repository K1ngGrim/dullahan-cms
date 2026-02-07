FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Dullahan.Cms.Content.Api/Dullahan.Cms.Content.Api.csproj", "Dullahan.Cms.Content.Api/"]
RUN dotnet restore "Dullahan.Cms.Content.Api/Dullahan.Cms.Content.Api.csproj"
COPY . .
WORKDIR "/src/Dullahan.Cms.Content.Api"
RUN dotnet build "./Dullahan.Cms.Content.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Dullahan.Cms.Content.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dullahan.Cms.Content.Api.dll"]
