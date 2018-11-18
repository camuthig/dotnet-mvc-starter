# .NET MVC Starter

## Prerequisites

* .NET Core 2.1 CLI
* [LibMan](https://docs.microsoft.com/en-us/aspnet/core/client-side/libman/libman-cli?view=aspnetcore-2.1)

## Preparing the Project

1. Update the database name in `docker-compose.yml` and `appsettings.Development.json` with your preferred name.
2. Run `dotnet restore` to pull dependencies
3. Install frontend dependencies with `libman install`

## Running the Project

Start a database with Docker

`docker-composer up -d`

Start the application

`dotnet run`
