# Moq Notes

## Dependency Injection

Dependency Injection supplies required objects from outside a class.

Advantages

- Loose Coupling

- Easy Testing

- Better Maintainability

---

## Mocking

A Mock object replaces a real dependency during testing.

---

## Moq

Popular .NET Mocking Framework.

Example

var mock = new Mock<IEmailService>();

---

## Verify

Checks whether a method was called.

Example

mock.Verify(x => x.SendEmail(...), Times.Once);

---

## Advantages

✔ Faster Tests

✔ No Database Required

✔ No API Calls

✔ Independent Unit Tests