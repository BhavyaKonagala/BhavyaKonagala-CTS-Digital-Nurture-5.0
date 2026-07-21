# EF Core Migrations

## What is a Migration?

A migration tracks database schema changes and updates the database accordingly.

---

## Add Migration

Creates migration files.

```bash
dotnet ef migrations add InitialCreate
```

---

## Update Database

Applies migrations to SQL Server.

```bash
dotnet ef database update
```

---

## Data Seeding

Initial data can be inserted using `HasData()`.

Example

```csharp
modelBuilder.Entity<Student>().HasData(...);
```

---

## Advantages

- Version-controlled schema
- Easy updates
- Team collaboration
- Automatic database creation