#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["thiagomotadev.OperationalResearchForEducation.Api/thiagomotadev.OperationalResearchForEducation.Api.csproj", "thiagomotadev.OperationalResearchForEducation.Api/"]
COPY ["thiagomotadev.OperationalResearchForEducation.Startup/thiagomotadev.OperationalResearchForEducation.Startup.csproj", "thiagomotadev.OperationalResearchForEducation.Startup/"]
COPY ["thiagomotadev.OperationalResearchForEducation.Application/thiagomotadev.OperationalResearchForEducation.Application.csproj", "thiagomotadev.OperationalResearchForEducation.Application/"]
COPY ["thiagomotadev.OperationalResearchForEducation.GoogleOrTools/thiagomotadev.OperationalResearchForEducation.GoogleOrTools.csproj", "thiagomotadev.OperationalResearchForEducation.GoogleOrTools/"]
RUN dotnet restore "thiagomotadev.OperationalResearchForEducation.Api/thiagomotadev.OperationalResearchForEducation.Api.csproj"
COPY . .
WORKDIR "/src/thiagomotadev.OperationalResearchForEducation.Api"
RUN dotnet build "thiagomotadev.OperationalResearchForEducation.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "thiagomotadev.OperationalResearchForEducation.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "thiagomotadev.OperationalResearchForEducation.Api.dll"]