# Dependency Injection (DI)

## Objective

Learn how Dependency Injection helps create loosely coupled applications by injecting dependencies instead of creating them inside a class.

## Definition

Dependency Injection is a design pattern where an object receives its dependencies from an external source rather than creating them itself.

## Explanation

In this example:

- `IService` is an interface.
- `Service` implements the interface.
- `Client` receives the service through its constructor.

The `Client` class does not create a `Service` object directly. Instead, the dependency is injected from outside.

## Technologies Used

- C#
- .NET Console Application
- Object-Oriented Programming

## How to Run

```bash
dotnet run
```

## Expected Output

```
Service Executed
```

## Advantages

- Loose coupling
- Better testability
- Easy maintenance
- Easy to replace implementations