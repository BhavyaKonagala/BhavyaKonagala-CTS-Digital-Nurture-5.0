# Liskov Substitution Principle (LSP)

## Objective

Understand the Liskov Substitution Principle and how subclasses should be able to replace their parent classes without affecting program correctness.

## Definition

The Liskov Substitution Principle states that:

> "Objects of a superclass should be replaceable with objects of its subclasses without changing the correctness of the program."

## Explanation

In this example:

- `Bird` is the base class.
- `Sparrow` inherits from `Bird`.
- A `Sparrow` object is assigned to a `Bird` reference.
- The program works correctly without modifying the existing code.

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
Sparrow flies
```

## Advantages

- Encourages proper inheritance
- Improves code reusability
- Makes software easier to maintain
- Supports polymorphism