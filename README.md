# Getting Started

### Prerequisite

.NET 5.0\
Visual Studio 2019 v16.8 (or better)\
SQL Server 2017 (or better)\

### 1. appsettings.json

Modify the `ConnectionStrings` in `appsettings.json` file in two projects `src\CarParkABP.DbMigrator` and `src\CarParkABP.HttpApi.Host`\
`"Default": "Server={YourPCName}\\{YourSQLInstanceName};Database={YourDBName};User Id=sa;Password={Password};"`

### 2. Build The Solution

### 3. CarParkABP.DbMigrator

Set `src\CarParkABP.DbMigrator` as Startup Project\
Hit `Ctrl + F5`\
After the program finish running, hit any button

### 4. CarParkABP.HttpApi.Host

Set `src\CarParkABP.HttpApi.Host` as Startup Project\
Hit `Ctrl + F5`