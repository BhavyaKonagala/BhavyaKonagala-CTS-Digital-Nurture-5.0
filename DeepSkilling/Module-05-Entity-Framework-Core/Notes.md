# Module 05 - Entity Framework Core Notes

# What is ORM?

Object-Relational Mapping (ORM) is a technique that maps database tables to C# classes.

Example

```
Student Table

↓

Student Class

↓

Student Object
```

Benefits

- Less SQL Code
- Better Productivity
- Easier Maintenance
- Strong Type Safety
- Automatic Mapping

---

# Entity Framework Core

Entity Framework Core (EF Core) is Microsoft's lightweight, open-source ORM framework for .NET applications.

It enables developers to interact with databases using C# objects instead of writing SQL statements manually.

---

# Features of EF Core

- Cross Platform
- LINQ Support
- Change Tracking
- Migrations
- Code First
- Database First
- Lazy Loading
- Eager Loading
- Asynchronous Operations

---

# DbContext

DbContext is the primary class responsible for communicating with the database.

Responsibilities

- Database Connection
- Change Tracking
- CRUD Operations
- Query Execution

---

# DbSet

Represents a table in the database.

Example

```csharp
public DbSet<Student> Students => Set<Student>();
```

---

# Code First Approach

Create entity classes first.

Entity Framework automatically creates the database schema from the C# classes.

---

# CRUD Operations

Create

```csharp
context.Students.Add(student);
```

Read

```csharp
context.Students.ToList();
```

Update

```csharp
context.SaveChanges();
```

Delete

```csharp
context.Students.Remove(student);
```

---

# LINQ

Language Integrated Query (LINQ) provides a simple and strongly typed way to query data.

Common Methods

- Where()
- Select()
- OrderBy()
- OrderByDescending()
- FirstOrDefault()
- Count()
- Average()
- Max()

---

# Migrations

Migrations help keep the database schema synchronized with the application's data model.

Commands

```bash
dotnet ef migrations add InitialCreate

dotnet ef database update
```

---

# Relationships

Entity Framework Core supports

- One-to-One
- One-to-Many
- Many-to-Many

Relationships are created using:

- Primary Keys
- Foreign Keys
- Navigation Properties

---

# Data Loading

### Eager Loading

Loads related data immediately.

```csharp
.Include(x => x.Students)
```

### Lazy Loading

Loads related data only when accessed.

### Explicit Loading

Loads related data manually when required.

---

# Performance Optimization

### AsNoTracking()

Used for read-only queries.

```csharp
context.Students.AsNoTracking();
```

Advantages

- Faster Queries
- Lower Memory Usage

---

# Batch Operations

Insert multiple records efficiently.

```csharp
context.Students.AddRange(list);
```

---

# RowVersion

Used for optimistic concurrency control.

```csharp
[Timestamp]
public byte[]? RowVersion { get; set; }
```

---

# Best Practices

- Use AsNoTracking() for read-only queries.
- Use asynchronous methods whenever possible.
- Keep DbContext lifetime short.
- Retrieve only required columns.
- Use migrations instead of EnsureCreated() for production.
- Avoid unnecessary database queries.
- Use AddRange() for bulk inserts.
- Create indexes on frequently searched columns.
- Use navigation properties effectively.
- Apply proper exception handling.

---

# Advantages of EF Core

✔ Faster Development

✔ Reduced SQL Code

✔ Strong Type Safety

✔ Automatic Database Mapping

✔ Easy CRUD Operations

✔ LINQ Integration

✔ Cross-Platform Support

✔ Migration Support

✔ High Performance

✔ Scalable Architecture

---

# Applications

- Banking Applications
- E-Commerce Platforms
- Hospital Management Systems
- Library Management Systems
- Student Management Systems
- Enterprise Resource Planning (ERP)
- Human Resource Management Systems

---

# Key Takeaways

✔ Entity Framework Core is Microsoft's modern ORM framework.

✔ DbContext manages database communication.

✔ DbSet represents database tables.

✔ Code First simplifies database creation.

✔ LINQ enables strongly typed database queries.

✔ Migrations manage schema changes efficiently.

✔ Navigation properties simplify relationships.

✔ AsNoTracking() improves read-only query performance.

✔ Batch operations reduce database round trips.

✔ EF Core enables scalable and maintainable .NET applications.