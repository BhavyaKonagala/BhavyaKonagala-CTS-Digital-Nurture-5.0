# Module 04 - NUnit and Moq Notes

## Automated Testing

Automated testing executes test cases automatically without manual intervention.

### Benefits

- Faster execution
- Better accuracy
- Reusable test cases
- Continuous testing
- Improved software quality

---

# Types of Testing

- Unit Testing
- Integration Testing
- System Testing
- Acceptance Testing

---

# Test Pyramid

The Test Pyramid recommends writing:

- Many Unit Tests
- Fewer Integration Tests
- Very Few UI Tests

This improves speed and maintainability.

---

# NUnit Framework

NUnit is an open-source unit testing framework for .NET applications.

Common Attributes

- [Test]
- [TestFixture]
- [SetUp]
- [TearDown]
- [TestCase]
- [Ignore]

---

# Test-Driven Development (TDD)

TDD follows three steps:

1. Write a failing test.
2. Write the minimum code to pass the test.
3. Refactor the code.

---

# Unit Testing Fundamentals

A good unit test should be:

- Independent
- Repeatable
- Fast
- Readable
- Reliable

---

# Assertions

Assertions compare expected and actual results.

Example

```csharp
Assert.That(actual, Is.EqualTo(expected));
```

Common Assertions

- Is.EqualTo()
- Is.True
- Is.False
- Does.Contain()
- Assert.Throws()

---

# Parameterized Tests

Parameterized tests execute the same test method with different input values.

Example

```csharp
[TestCase(5, true)]
[TestCase(8, false)]
```

---

# Exception Testing

Exceptions are tested using:

```csharp
Assert.Throws<Exception>(() => Method());
```

---

# Dependency Injection (DI)

Dependency Injection provides required objects from outside the class instead of creating them internally.

Advantages

- Loose Coupling
- Better Testability
- Easier Maintenance
- Improved Reusability

---

# Mocking

Mocking replaces real external dependencies with fake objects during testing.

Benefits

- Faster tests
- No database dependency
- No external API calls
- Isolated testing

---

# Moq Framework

Moq is a popular .NET mocking framework used for creating mock objects.

Example

```csharp
var mock = new Mock<IEmailService>();
```

---

# Verify

Verify checks whether a mocked method was called.

Example

```csharp
mock.Verify(x => x.SendEmail("Hello"), Times.Once);
```

---

# Interaction Testing

Interaction testing verifies communication between objects rather than checking only return values.

---

# Code Coverage

Code coverage measures how much of the application's source code is executed during testing.

Higher code coverage generally indicates better-tested applications, although 100% coverage does not always guarantee bug-free software.

---

# Best Practices

- Write small and focused tests.
- Use meaningful test names.
- Avoid test dependencies.
- Mock external services.
- Test both positive and negative scenarios.
- Keep production code and test code separate.

---

# Key Takeaways

✔ NUnit is a powerful unit testing framework for .NET.

✔ Automated testing saves development time.

✔ Parameterized tests reduce duplicate code.

✔ Assertions validate expected results.

✔ Dependency Injection improves testability.

✔ Moq isolates external dependencies.

✔ Interaction testing verifies object collaboration.

✔ Good unit tests are fast, independent, and reliable.

✔ Code coverage helps measure test effectiveness.

✔ Unit testing improves software quality and maintainability.