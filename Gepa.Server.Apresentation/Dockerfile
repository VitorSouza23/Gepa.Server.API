FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

COPY ["Gepa.Server.Domain/Gepa.Server.Entity.csproj", "Gepa.Server.Domain/"]
COPY ["Gepa.Server.Application/Gepa.Server.Application.csproj", "Gepa.Server.Application/"]
COPY ["Gepa.Server.Infra.Data/Gepa.Server.Infra.Data.csproj", "Gepa.Server.Infra.Data/"]

COPY ["Gepa.Server.Apresentation/Gepa.Server.Apresentation.csproj", "Gepa.Server.Apresentation/"]
RUN dotnet restore "Gepa.Server.Apresentation/Gepa.Server.Apresentation.csproj"
COPY . .
WORKDIR "/src/Gepa.Server.Apresentation"
RUN dotnet build "Gepa.Server.Apresentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gepa.Server.Apresentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gepa.Server.Apresentation.dll"]
