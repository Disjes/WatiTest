FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WatiTest/WatiTest.csproj", "WatiTest/"]
RUN dotnet restore "WatiTest/WatiTest.csproj"
COPY . .
WORKDIR "/src/WatiTest"
RUN dotnet build "WatiTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WatiTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WatiTest.dll"]
