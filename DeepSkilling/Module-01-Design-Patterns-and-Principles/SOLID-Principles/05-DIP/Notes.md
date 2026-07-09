# Dependency Inversion Principle (DIP)

## Definition

High-level modules should depend on abstractions (interfaces), not on concrete classes.

## Purpose

Reduce dependency between classes and make the application flexible.

## Example Used

Interface:

- IMessage

Classes:

- Email
- Notification

The Notification class communicates through the IMessage interface instead of directly using the Email class.

## Real-World Example

A notification system can send messages through:

- Email
- SMS
- WhatsApp

Instead of directly creating an Email object inside Notification, an interface is used.

This allows adding new message services without changing the Notification class.

## Advantages

- Loose coupling
- Better code reuse
- Easy testing using mocks
- Easy maintenance
- Supports scalability

## Key Takeaway

Depend on interfaces (abstractions), not concrete implementations.