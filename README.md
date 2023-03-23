# :wrench: GitHub Actions Playground
[![Azure Web App Deployment](https://github.com/philipp-meier/GitHubActionsPlayground/actions/workflows/azure-webapps-dotnet-core.yml/badge.svg?branch=main)](https://github.com/philipp-meier/GitHubActionsPlayground/actions/workflows/azure-webapps-dotnet-core.yml)
[![Continuous Integration](https://github.com/philipp-meier/GitHubActionsPlayground/actions/workflows/dotnet.yml/badge.svg)](https://github.com/philipp-meier/GitHubActionsPlayground/actions/workflows/dotnet.yml)  
Playground for testing ASP.NET Core [GitHub Actions](https://docs.github.com/en/actions) and [Azure App Service deployments](https://learn.microsoft.com/en-us/azure/app-service/deploy-github-actions).

## Features
- [x] Simple CI pipeline for pull requests.
- [x] Branch protection rules for pushing to `main` (includes executing the CI pipeline).
- [x] Automated [Azure Web App](https://azure.microsoft.com/en-us/products/app-service/web/) deployment, when pushing to the `Server`-directory of `main`.

## Azure App Service setup
The `Server` application was added to Azure with the `Azure App Service: Create New Web App... (Advanced)` command of the Visual Code extension [Azure Tools](https://marketplace.visualstudio.com/items?itemName=ms-vscode.vscode-node-azure-pack).  
This command creates an [Azure App Service-Plan](https://learn.microsoft.com/en-us/azure/app-service/overview-hosting-plans) with the required [App Service](https://azure.microsoft.com/en-us/products/app-service/) (Web App).  

The application can then be deployed with the `Azure App Service: Deploy to Web App` command of the Azure Tools extension, or with a simple deployment workflow (see `azure-webapps-dotnet-core.yml`). This requires you to create a **repository secret** called `AZURE_WEBAPP_PUBLISH_PROFILE` (*Settings -> Security -> Secrets and variables -> Actions -> New repository Secret*).

Values entered in the "Secrets and variables"-section are not visible to anyone else. The required publish profile can be downloaded from the [Azure portal](https://portal.azure.com/) directly in the corresponding app-service overview page (next to "Start", "Stop", "Refresh" and "Delete").

## Initial project setup
- `dotnet new webapi -o Server`
- `dotnet new xunit -o Server.Tests`
- `dotnet new sln`
- `dotnet sln add ./Server/Server.csproj`
- `dotnet sln add ./Server.Tests/Server.Tests.csproj`
- `dotnet add ./Server.Tests/Server.Tests.csproj reference ./Server/Server.csproj`