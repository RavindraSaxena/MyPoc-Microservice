FROM  microsoft/dotnet:2.1-sdk AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "MyPoc.Web.dll"]


#FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
#WORKDIR /app
#EXPOSE 80
##EXPOSE 44375
#
#FROM microsoft/dotnet:2.1-sdk AS build
#WORKDIR /src
#COPY ["MyPoc.Web/MyPoc.Web.csproj", "MyPoc.Web/"]
#RUN dotnet restore "MyPoc.Web/MyPoc.Web.csproj"
#COPY . .
#WORKDIR "/src/MyPoc.Web"
#RUN dotnet build "MyPoc.Web.csproj" -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish "MyPoc.Web.csproj" -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "MyPoc.Web.dll"]