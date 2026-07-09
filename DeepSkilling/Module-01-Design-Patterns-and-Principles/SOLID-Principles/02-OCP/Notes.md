# Open/Closed Principle (OCP)

## Definition

Software entities should be open for extension but closed for modification.

## Purpose

The existing code should not be changed every time a new feature is added.

Instead, create new classes that extend the existing functionality.

## Real-World Example

Consider a payment application.

Initially it supports:

- Credit Card

Later the client requests:

- UPI
- PayPal
- Net Banking

Instead of modifying the existing payment class, create new payment classes.

## Example Used

The program contains:

- Shape (Abstract Class)
- Circle
- Rectangle

Each shape calculates its own area using the overridden `Area()` method.

## Advantages

- Improves maintainability
- Supports scalability
- Reduces bugs
- Encourages reusable code
- Follows Object-Oriented Programming principles

## Key Takeaway

Add new functionality by creating new classes instead of modifying existing classes.