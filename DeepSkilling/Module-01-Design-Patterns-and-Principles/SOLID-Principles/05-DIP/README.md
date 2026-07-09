# Dependency Inversion Principle (DIP)

## Objective

Understand the Dependency Inversion Principle and learn how high-level modules should depend on abstractions rather than concrete implementations.

## Definition

The Dependency Inversion Principle states that:

> "High-level modules should not depend on low-level modules. Both should depend on abstractions."

## Explanation

In this example:

- `IMessage` is an interface.
- `Email` implements the `IMessage` interface.
- `Notification` depends on the `IMessage` interface instead of the `Email` class.

This allows different message services (Email, SMS, WhatsApp) to be used without modifying the `Notification` class.

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
Email Sent
```

## Advantages

- Loose coupling
- Easy to extend
- Easy to test
- Better maintainability