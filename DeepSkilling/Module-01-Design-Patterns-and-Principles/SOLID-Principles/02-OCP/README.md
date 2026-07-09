# Open/Closed Principle (OCP)

## Objective

Understand the Open/Closed Principle and learn how to design software that is easy to extend without modifying existing code.

## Definition

The Open/Closed Principle states that:

> "Software entities (classes, modules, functions) should be open for extension but closed for modification."

## Explanation

Instead of modifying existing classes whenever new functionality is required, we extend the existing classes by creating new classes.

In this example:

- `Shape` is an abstract class.
- `Circle` and `Rectangle` extend the `Shape` class.
- Each class implements its own `Area()` method.

If a new shape like `Triangle` is required, we simply create a new class without changing the existing code.

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
Circle Area: 78.5
Rectangle Area: 24
```

## Advantages

- Easy to extend
- Easy to maintain
- Reduces code modification
- Supports reusable code