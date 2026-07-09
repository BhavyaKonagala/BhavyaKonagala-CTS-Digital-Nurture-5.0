# Dependency Injection (DI)

## Definition

Dependency Injection is a technique where required objects (dependencies) are provided from outside the class instead of being created inside it.

## Purpose

To reduce coupling between classes and improve flexibility.

## Example Used

Interface:

- IService

Classes:

- Service
- Client

The Client class receives an IService object through its constructor.

## Real-World Example

A payment application may support:

- Credit Card
- UPI
- Net Banking

Instead of creating a payment object inside the application, the required payment service is injected.

## Advantages

- Loose coupling
- Better code reuse
- Easier unit testing
- Easy maintenance
- Supports scalability

## Key Takeaway

Inject dependencies through constructors or methods instead of creating them directly inside the class.