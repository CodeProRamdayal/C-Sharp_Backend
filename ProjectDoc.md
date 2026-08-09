# .NET Project Setup

## Commands

### 1. List available templates

```bash
dotnet new list
```

Select the solution file template:

1. ASP.NET Core Web API - `webapi`
2. Solution File - `sln`, `solution`

### 2. Create the API project

```bash
dotnet new webapi -n API -controllers
```

The template "ASP.NET Core Web API" was created successfully.

### 3. Create class library projects

```bash
dotnet new classlib -n Domain
dotnet new classlib -n Persistence
dotnet new classlib -n Application
```

The template "Class Library" was created successfully.

## Recent Changes — Switched to SQL Server

- Switched EF Core provider from SQLite to SQL Server (LocalDB by default).
- Added `AppDbContext` DI constructor and registered it in the `API` startup to use `UseSqlServer(...)`.
- Added `ConnectionStrings:DefaultConnection` to `API/appsettings.json` (update for real server).
- Added EF Core SQL Server package references and a `ProjectReference` from `API` to `Persistence`.
- Created initial migration files under `Persistence/Migrations`.

Run these commands from the repository root to restore, build, and apply migrations:

```bat
cd "C:\Users\Ram\Documents\.Net\Reactivities"
dotnet restore Reactivities.slnx
dotnet build Reactivities.slnx -c Debug

:: (optional) create/apply migrations — requires dotnet-ef tool
dotnet tool install --global dotnet-ef
cd API
dotnet ef migrations add InitialCreate -p ..\Persistence\Persistence.csproj -s API.csproj
dotnet ef database update -p ..\Persistence\Persistence.csproj -s API.csproj
```

See `REPO_CHANGELOG.md` for a full summary and file-by-file details.

### 4. Add projects to the solution

```bash
dotnet sln add API
dotnet sln add Application
dotnet sln add Domain
dotnet sln add Persistence
```

Example output:

```text
Project 'API/API.csproj' added to the solution.
```
