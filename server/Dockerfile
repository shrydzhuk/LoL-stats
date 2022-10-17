# Server

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /server

# Copy csproj and restore as distinct layers
COPY ./*.sln .
COPY ./LoL.Stats.Api/*.csproj ./LoL.Stats.Api/
COPY ./LoL.Stats.Application/*.csproj ./LoL.Stats.Application/
COPY ./LoL.Stats.Domain/*.csproj ./LoL.Stats.Domain/
COPY ./LoL.Stats.Riot.Api/*.csproj ./LoL.Stats.Riot.Api/
RUN dotnet restore

# Copy everything else and build
COPY ./LoL.Stats.Api/. ./LoL.Stats.Api/
COPY ./LoL.Stats.Application/. ./LoL.Stats.Application/
COPY ./LoL.Stats.Domain/. ./LoL.Stats.Domain/ 
COPY ./LoL.Stats.Riot.Api/. ./LoL.Stats.Riot.Api/

WORKDIR /server/LoL.Stats.Api/
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
COPY --from=build-env /server/LoL.Stats.Api/out .

EXPOSE 5000
ENTRYPOINT ["dotnet", "LoL.Stats.Api.dll"]