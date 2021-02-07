FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /LearnAzureDevOps
COPY . ./
RUN dotnet restore LearnAzureDevOps.csproj
RUN dotnet publish LearnAzureDevOps.csproj --no-restore --configuration Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /LearnAzureDevOps
COPY --from=build /app .

ENTRYPOINT ["dotnet", "LearnAzureDevOps.dll"]
