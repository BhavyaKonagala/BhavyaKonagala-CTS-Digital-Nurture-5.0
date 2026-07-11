# Core Unit Testing Techniques

## String Testing

Verify returned strings using Assert.That().

---

## Array Testing

Verify length and values.

Example

Assert.That(array.Length, Is.EqualTo(5));

---

## Collection Testing

CollectionAssert.Contains()

CollectionAssert.AreEqual()

---

## Return Value Testing

Verify expected output.

---

## Void Method Testing

Call the method and verify state changes.

---

## Exception Testing

Assert.Throws<Exception>()

---

## Code Coverage

Measures how much of your source code is executed by tests.

Higher coverage generally indicates better-tested code.

---

## Key Points

✔ Test expected values.

✔ Test invalid inputs.

✔ Test exceptions.

✔ Keep tests independent.