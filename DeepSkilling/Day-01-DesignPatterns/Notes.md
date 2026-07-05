# Day 01 – Design Patterns and Principles

## Objective

The objective of this module is to understand software design principles and commonly used design patterns. These principles help developers write maintainable, scalable, and reusable code.

---

## SOLID Principles

### 1. Single Responsibility Principle (SRP)

A class should have only one responsibility and one reason to change.

#### Benefits

* Easier maintenance
* Better readability
* Reduced complexity
* Improved testing

### 2. Open Closed Principle (OCP)

Software entities should be open for extension but closed for modification.

#### Benefits

* New functionality can be added without changing existing code.
* Reduces the risk of introducing bugs.

### 3. Liskov Substitution Principle (LSP)

Derived classes should be replaceable for their base classes without affecting program correctness.

#### Benefits

* Better inheritance structure
* Improved reliability

### 4. Interface Segregation Principle (ISP)

Clients should not be forced to depend on interfaces they do not use.

#### Benefits

* Smaller interfaces
* Better modularity

### 5. Dependency Inversion Principle (DIP)

High-level modules should depend on abstractions rather than concrete implementations.

#### Benefits

* Loose coupling
* Easier testing
* Better flexibility

---

# Design Patterns

## Creational Patterns

### Singleton Pattern

Ensures that only one instance of a class exists.

### Factory Method Pattern

Creates objects without exposing creation logic.

### Builder Pattern

Constructs complex objects step by step.

---

## Structural Patterns

### Adapter Pattern

Allows incompatible interfaces to work together.

### Decorator Pattern

Adds functionality dynamically.

### Proxy Pattern

Provides a placeholder for another object.

---

## Behavioral Patterns

### Observer Pattern

Defines a one-to-many dependency between objects.

### Strategy Pattern

Allows algorithms to be selected at runtime.

### Command Pattern

Encapsulates requests as objects.

---

# Hands-On Exercises

## Program 1 – Hello Cognizant

A simple C# console application used to verify .NET installation and program execution.

### Output

Hello Cognizant!

---

## Program 2 – Single Responsibility Principle (SRP)

Implemented SRP by separating invoice calculation and invoice printing into different classes.

### Output

Calculating invoice total...

Printing invoice...

---

# Learning Outcome

* Understood SOLID principles.
* Learned commonly used design patterns.
* Installed and configured .NET SDK.
* Created and executed C# console applications.
* Implemented Single Responsibility Principle.
* Improved understanding of maintainable software design.
