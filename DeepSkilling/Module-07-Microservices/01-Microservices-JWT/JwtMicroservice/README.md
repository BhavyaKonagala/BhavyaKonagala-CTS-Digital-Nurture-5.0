# JWT Microservice

## Overview

This project demonstrates JWT Authentication in ASP.NET Core Web API.

## Features

- ASP.NET Core Web API
- JWT Authentication
- Protected API Endpoint
- Swagger Integration
- Exception Middleware

## Technologies

- ASP.NET Core
- C#
- JWT Bearer Authentication
- Swagger

## API Endpoints

### Login

POST

```
/api/Auth/login
```

Sample Request

```json
{
  "username": "admin",
  "password": "admin123"
}
```

### Protected Endpoint

GET

```
/api/Auth/secure
```

Requires JWT Bearer Token.

## Run

```
dotnet run
```