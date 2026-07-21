# Setting up EF Core

## DbContext

DbContext is the main class that manages database connections and operations.

Example

```csharp
public class StudentContext : DbContext
```

---

## DbSet

Represents a table in the database.

Example

```csharp
public DbSet<Student> Students { get; set; }
```

---

## Connection String

Defines how EF Core connects to SQL Server.

Example

```text
Server=localhost\SQLEXPRESS;
Database=StudentDB;
Trusted_Connection=True;
TrustServerCertificate=True;
```

---

## EnsureCreated()

Creates the database if it does not already exist.

---

## Advantages

- Automatic Database Creation
- Simple Configuration
- Easy SQL Server Integration