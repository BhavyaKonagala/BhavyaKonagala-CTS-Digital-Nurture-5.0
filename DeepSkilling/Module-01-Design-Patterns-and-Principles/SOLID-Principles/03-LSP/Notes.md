# Liskov Substitution Principle (LSP)

## Definition

A subclass should be able to replace its parent class without changing the behavior of the program.

## Purpose

Inheritance should preserve the expected behavior of the base class.

## Example Used

The program contains:

- Bird (Base Class)
- Sparrow (Derived Class)

The `Sparrow` object is treated as a `Bird`, and the program executes correctly.

## Real-World Example

Consider a payment system.

Base Class:
- Payment

Derived Classes:
- CreditCardPayment
- UPIPayment
- NetBankingPayment

Any payment type can replace the base `Payment` object without breaking the application.

## Advantages

- Proper use of inheritance
- Supports polymorphism
- Improves maintainability
- Reduces unexpected behavior

## Key Takeaway

Derived classes should behave like their base classes and should not break the expected functionality.