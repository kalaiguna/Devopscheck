FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY ["src/myapi/myapi.csproj", "src/myapi/"]
RUN dotnet restore "src/myapi/myapi.csproj"
COPY . .
WORKDIR "/src/src/myapi"
RUN dotnet build "myapi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "myapi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "myapi.dll"]
