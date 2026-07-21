# Product Management API

## Overview

This project demonstrates advanced ASP.NET Core Web API concepts by developing a Product Management API. The application follows the Repository Pattern and Dependency Injection principles to create a clean, maintainable, and scalable architecture.

## Features

- RESTful CRUD Operations
- Entity Framework Core with SQL Server
- Repository Pattern
- Dependency Injection
- DTO (Data Transfer Object)
- Swagger API Documentation
- Model Validation
- SQL Server Integration

## Technologies Used

- ASP.NET Core Web API (.NET 10)
- C#
- Entity Framework Core
- SQL Server
- Swagger (OpenAPI)

## Project Structure

```
ProductAPI
│
├── Controllers
├── Models
├── DTOs
├── Data
├── Interfaces
├── Repositories
├── Services
├── Migrations
├── Program.cs
├── appsettings.json
└── ProductAPI.csproj
```

## API Endpoints

| Method | Endpoint | Description |
|---------|----------|-------------|
| GET | /api/Products | Get all products |
| GET | /api/Products/{id} | Get product by ID |
| POST | /api/Products | Add a new product |
| PUT | /api/Products/{id} | Update product |
| DELETE | /api/Products/{id} | Delete product |

## Sample Request

```json
{
  "name": "Laptop",
  "price": 55000,
  "category": "Electronics",
  "stock": 10
}
```

## Output

- Product records are stored in SQL Server.
- APIs can be tested using Swagger UI.
- Supports complete CRUD operations.

## Learning Outcomes

- Repository Pattern
- Dependency Injection
- DTO Implementation
- Entity Framework Core
- SQL Server Integration
- Swagger Documentation