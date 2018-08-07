FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 16915
EXPOSE 44381

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY MyProductRestAPI/MyProductRestAPI.csproj MyProductRestAPI/
RUN dotnet restore MyProductRestAPI/MyProductRestAPI.csproj
COPY . .
WORKDIR /src/MyProductRestAPI
RUN dotnet build MyProductRestAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish MyProductRestAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyProductRestAPI.dll"]
