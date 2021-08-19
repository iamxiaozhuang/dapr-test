#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

ARG NET_IMAGE=5.0-buster-slim
FROM mcr.microsoft.com/dotnet/aspnet:${NET_IMAGE} AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:${NET_IMAGE} AS build
WORKDIR /src
COPY ["ServiceApi/DaprTest1.ServiceApi1/DaprTest1.ServiceApi1.csproj", "ServiceApi/DaprTest1.ServiceApi1/"]
COPY ["Shared/DaprTest1.Shared.csproj", "Shared/"]
RUN dotnet restore "ServiceApi/DaprTest1.ServiceApi1/DaprTest1.ServiceApi1.csproj"
COPY . .
WORKDIR "/src/ServiceApi/DaprTest1.ServiceApi1"
RUN dotnet build "DaprTest1.ServiceApi1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DaprTest1.ServiceApi1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DaprTest1.ServiceApi1.dll"]