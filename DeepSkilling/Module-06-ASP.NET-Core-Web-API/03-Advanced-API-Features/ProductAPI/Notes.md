# Advanced API Features - Notes

## What is a Repository Pattern?

The Repository Pattern separates data access logic from business logic. It provides a clean interface to perform database operations.

Advantages:
- Loose coupling
- Better code organization
- Easy testing
- Improved maintainability

---

## Dependency Injection (DI)

Dependency Injection is a design pattern where required objects are provided automatically instead of being created manually.

Benefits:
- Reduces coupling
- Easier unit testing
- Better scalability

Example:

```csharp
builder.Services.AddScoped<IProductRepository, ProductRepository>();
```

---

## DTO (Data Transfer Object)

A DTO is used to transfer only the required data between the client and the server.

Benefits:
- Improves security
- Reduces unnecessary data transfer
- Simplifies API responses

---

## Entity Framework Core

Entity Framework Core is an Object Relational Mapper (ORM).

Features:
- Database connectivity
- CRUD operations
- LINQ queries
- Migrations
- Automatic table generation

---

## Swagger

Swagger provides interactive API documentation.

Advantages:
- API testing
- Request and response examples
- Easy debugging
- Automatic documentation

---

## CRUD Operations

Create
- Adds a new product

Read
- Retrieves product information

Update
- Modifies existing product details

Delete
- Removes a product from the database

---

## Project Workflow

Client

↓

Controller

↓

Repository

↓

Entity Framework Core

↓

SQL Server Database

---

## Concepts Learned

- ASP.NET Core Web API
- Repository Pattern
- Dependency Injection
- DTO
- Entity Framework Core
- SQL Server
- Swagger
- RESTful API Design