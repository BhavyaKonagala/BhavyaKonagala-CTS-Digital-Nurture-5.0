# Module 01 Notes

## SOLID Principles

### SRP

A class should have only one responsibility and one reason to change.

Example:
Invoice calculation and invoice printing should be handled by different classes.

---

### OCP

Software entities should be open for extension but closed for modification.

Example:
Add new Shape classes without changing existing code.

---

### LSP

Derived classes should be replaceable for their base classes without affecting program correctness.

Example:
Sparrow can replace Bird.

---

### ISP

Clients should not be forced to implement interfaces they do not use.

Example:
Separate Print and Scan interfaces.

---

### DIP

High-level modules should depend on abstractions rather than concrete implementations.

Example:
Notification depends on IMessage instead of Email.

---

### Dependency Injection

Dependencies are provided from outside the class rather than being created inside it.

Benefits:

- Loose Coupling
- Easy Testing
- Easy Maintenance

---

## Design Patterns

### Creational Patterns

Used for object creation.

- Singleton
- Factory Method
- Builder

---

### Structural Patterns

Used for organizing classes and objects.

- Adapter
- Decorator
- Proxy

---

### Behavioral Patterns

Used for communication between objects.

- Observer
- Strategy
- Command

---

### MVC

Separates the application into:

- Model
- View
- Controller

---

## Benefits

- Better code organization
- Improved maintainability
- Loose coupling
- High reusability
- Easy scalability