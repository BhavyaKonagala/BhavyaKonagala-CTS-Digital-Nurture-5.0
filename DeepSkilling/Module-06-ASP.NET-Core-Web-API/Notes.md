# Module 06 - ASP.NET Core Web API Notes

## What is ASP.NET Core Web API?

ASP.NET Core Web API is a framework used to build RESTful services that allow applications to communicate over HTTP.

---

## REST API

REST (Representational State Transfer) is an architectural style for designing web services.

Characteristics:
- Stateless
- Client-Server Architecture
- Resource-Based
- Uses HTTP Methods

---

## HTTP Methods

GET
- Retrieve data

POST
- Create new data

PUT
- Update existing data

DELETE
- Remove data

---

## Controller

A controller receives HTTP requests, processes them, and returns responses to the client.

---

## Routing

Routing maps incoming HTTP requests to controller actions.

Example:

```
api/Student
api/Product
api/Employee
```

---

## CRUD Operations

Create
- Insert new records

Read
- Retrieve records

Update
- Modify existing records

Delete
- Remove records

---

## Entity Framework Core

Entity Framework Core (EF Core) is Microsoft's ORM used to interact with databases using C# objects.

Features:
- Database Migrations
- LINQ Queries
- CRUD Operations
- SQL Server Integration

---

## SQL Server

SQL Server stores application data and works with Entity Framework Core for database operations.

---

## Repository Pattern

The Repository Pattern separates business logic from data access logic.

Advantages:
- Loose Coupling
- Better Code Organization
- Easier Testing
- Improved Maintainability

---

## Dependency Injection (DI)

Dependency Injection automatically provides required services to classes instead of creating them manually.

Benefits:
- Better Maintainability
- Reusable Code
- Easier Unit Testing

---

## DTO (Data Transfer Object)

DTOs transfer only the required data between the client and server.

Advantages:
- Improved Security
- Reduced Data Transfer
- Cleaner API Responses

---

## Middleware

Middleware processes HTTP requests and responses before they reach controllers.

Examples:
- Authentication
- Logging
- Exception Handling

---

## Exception Handling

Global exception handling catches unhandled exceptions and returns meaningful error responses.

---

## JWT Authentication

JWT (JSON Web Token) is used to securely authenticate users.

Structure:
- Header
- Payload
- Signature

---

## Authorization

Authorization determines whether an authenticated user has permission to access a resource.

---

## SOAP

SOAP (Simple Object Access Protocol) is an XML-based protocol used for exchanging structured information between applications.

Advantages:
- High Security
- Reliable Messaging
- Enterprise Support

---

## WCF

Windows Communication Foundation (WCF) is a Microsoft framework used to build service-oriented applications.

Components:
- Service Contract
- Operation Contract
- Endpoint
- Binding
- Host

---

## Swagger

Swagger (OpenAPI) provides interactive API documentation and allows developers to test endpoints directly from the browser.

Advantages:
- Automatic Documentation
- Interactive Testing
- Easy Debugging

---

## API Testing

APIs can be tested using:
- Swagger UI
- Postman
- Browser (GET Requests)

---

## Summary

This module introduced the complete lifecycle of ASP.NET Core Web API development, including creating APIs, performing CRUD operations, connecting with SQL Server, implementing design patterns, securing APIs with JWT, handling exceptions, understanding SOAP/WCF, and documenting/testing APIs using Swagger.