# GitHub Actions Playground
## Project setup
- `dotnet new webapi -o Server`
- `dotnet new xunit -o Server.Tests`
- `dotnet new sln`
- `dotnet sln add ./Server/Server.csproj`
- `dotnet sln add ./Server.Tests/Server.Tests.csproj`
- `dotnet add ./Server.Tests/Server.Tests.csproj reference ./Server/Server.csproj`