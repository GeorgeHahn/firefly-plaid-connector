FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
# (Return this when the library situation is sorted.)
# COPY *.csproj ./
# RUN dotnet restore

# copy and publish app and libraries
COPY . ./
RUN cd firefly-plaid-connector && dotnet restore && dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS runtime
WORKDIR /app
COPY --from=build /app/firefly-plaid-connector/out ./
ENV CONFIG_PATH=/config
ENTRYPOINT ["dotnet", "firefly-plaid-connector.dll"]
