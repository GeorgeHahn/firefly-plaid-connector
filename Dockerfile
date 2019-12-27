FROM microsoft/dotnet:3.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy and publish app and libraries
COPY . ./
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:3.1-runtime AS runtime
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "firefly-plaid-connector.dll"]
