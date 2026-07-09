# Interface Segregation Principle (ISP)

## Objective

Understand the Interface Segregation Principle and learn how to create small, specific interfaces instead of one large interface.

## Definition

The Interface Segregation Principle states that:

> "Clients should not be forced to depend on interfaces they do not use."

## Explanation

Instead of creating one large interface with multiple methods, we split it into smaller interfaces.

In this example:

- `IPrint` contains only the `Print()` method.
- `IScan` contains only the `Scan()` method.
- `Printer` implements only `IPrint`.
- `AllInOnePrinter` implements both `IPrint` and `IScan`.

This allows each class to implement only the functionality it requires.

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
Printing document...
Printing document...
Scanning document...
```

## Advantages

- Smaller interfaces
- Better flexibility
- Easier maintenance
- Reduced unnecessary dependencies