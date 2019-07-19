FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 57257
EXPOSE 44371

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MyPoc.Sql/MyPoc.Sql.csproj", "MyPoc.Sql/"]
RUN dotnet restore "MyPoc.Sql/MyPoc.Sql.csproj"
COPY . .
WORKDIR "/src/MyPoc.Sql"
RUN dotnet build "MyPoc.Sql.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MyPoc.Sql.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyPoc.Sql.dll"]