# Practical 17: Entity Framework Core Models with Repository Pattern

This project demonstrates code-first approach with Entity Framework Core, implementing repository pattern and dependency injection. Note that this is a foundational structure project focused on model creation and database setup - there is no user interface or visual output.

## Project Overview

- Entity Framework Core Code-First migration
- Database models for Students, Users, and Roles
- Repository Pattern implementation with Dependency Injection
- Service lifetime configurations (Scoped vs Singleton vs Transient)

## Database Configuration

The application uses the following connection string in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.\\SQLEXPRESS;Database=Practical17;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

> **Note:** Modify the connection string if your SQL Server configuration differs.

## Applying Migrations

Since migration files are already included in the project, you only need to apply them to create the database structure:

1. Open the Package Manager Console (Tools > NuGet Package Manager > Package Manager Console)
2. Run the following command:
   ```
   Update-Database
   ```

This will create the database and apply all existing migrations.

## Project Structure

- **Models**: Contains entity classes
- **Data**: Includes DbContext and migrations
- **Repositories**: Repository pattern implementation
- **Services**: Service interfaces and implementations

## Service Lifetimes

The project demonstrates different service lifetimes:

- **Scoped**: Created once per client request
- **Singleton**: Created once and reused for the entire application lifetime
- **Transient**: Created each time they are requested

These are configured in the `Startup.cs` file.

## Notes

This project is focused on backend architecture and does not include any views or controllers for displaying data. It serves as a foundation for understanding EF Core, repository pattern, and dependency injection.
