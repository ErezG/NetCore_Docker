#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS build
WORKDIR /src
COPY . "AWS_Demo_App/"
WORKDIR "/src/AWS_Demo_App"
RUN dotnet restore "AWS_Demo_App.csproj"
RUN dotnet build "AWS_Demo_App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AWS_Demo_App.csproj" --force -c Release -o /app/publish -p:PublishTrimmed=true --self-contained --runtime alpine-x64

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["./AWS_Demo_App"]