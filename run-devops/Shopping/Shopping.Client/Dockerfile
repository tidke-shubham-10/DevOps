#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# ------------- This Part is For Building Applications ----------------
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Shopping.Client/Shopping.Client.csproj", "Shopping.Client/"]
RUN dotnet restore "Shopping.Client/Shopping.Client.csproj"
COPY . .
WORKDIR "/src/Shopping.Client"
RUN dotnet build "Shopping.Client.csproj" -c Release -o /app/build

# ------------- This Part is For Publishing/Running Applications ----------------
FROM build AS publish
RUN dotnet publish "Shopping.Client.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shopping.Client.dll"]