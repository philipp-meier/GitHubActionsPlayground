# :wrench: GitHub Actions Playground
[![Azure Web App Deployment](https://github.com/philipp-meier/GitHubActionsPlayground/actions/workflows/azure-webapps-dotnet-core.yml/badge.svg?branch=main)](https://github.com/philipp-meier/GitHubActionsPlayground/actions/workflows/azure-webapps-dotnet-core.yml)
[![Continuous Integration](https://github.com/philipp-meier/GitHubActionsPlayground/actions/workflows/dotnet.yml/badge.svg)](https://github.com/philipp-meier/GitHubActionsPlayground/actions/workflows/dotnet.yml)  
Playground for testing ASP.NET Core [GitHub Actions](https://docs.github.com/en/actions) and [Azure App Service deployments](https://learn.microsoft.com/en-us/azure/app-service/deploy-github-actions).

## Features
- [x] Simple CI pipeline for pull requests.
- [x] Branch protection rules for pushing to `main` (includes executing the CI pipeline).
- [x] Automated [Azure Web App](https://azure.microsoft.com/en-us/products/app-service/web/) deployment, when pushing to `main`.

## Initial project setup
- `dotnet new webapi -o Server`
- `dotnet new xunit -o Server.Tests`
- `dotnet new sln`
- `dotnet sln add ./Server/Server.csproj`
- `dotnet sln add ./Server.Tests/Server.Tests.csproj`
- `dotnet add ./Server.Tests/Server.Tests.csproj reference ./Server/Server.csproj`