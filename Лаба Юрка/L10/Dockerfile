FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Лаба Юрка/Лаба Юрка.csproj", "Лаба Юрка/"]
RUN dotnet restore "Лаба Юрка/Лаба Юрка.csproj"
COPY . .
WORKDIR "/src/Лаба Юрка"
RUN dotnet build "Лаба Юрка.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Лаба Юрка.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Лаба Юрка.dll"]
