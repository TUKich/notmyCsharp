FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["L11/L11.csproj", "L11/"]
RUN dotnet restore "L11/L11.csproj"
COPY . .
WORKDIR "/src/L11"
RUN dotnet build "L11.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "L11.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "L11.dll"]
