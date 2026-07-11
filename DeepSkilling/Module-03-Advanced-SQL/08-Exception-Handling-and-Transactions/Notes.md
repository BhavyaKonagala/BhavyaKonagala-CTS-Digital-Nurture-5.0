# Exception Handling and Transactions Notes

## TRY...CATCH

Used to handle runtime exceptions.

Syntax

BEGIN TRY
    SQL Statements
END TRY

BEGIN CATCH
    ERROR_MESSAGE()
END CATCH

---

## THROW

Raises a custom exception.

Syntax

THROW ErrorNumber,'Message',State;

---

## Transactions

Transaction is a group of SQL statements executed as one unit.

Commands

- BEGIN TRANSACTION
- COMMIT
- ROLLBACK

---

## COMMIT

Permanently saves changes.

---

## ROLLBACK

Undo all changes.

---

## ACID Properties

A - Atomicity

C - Consistency

I - Isolation

D - Durability

---

## Key Points

✔ TRY handles errors.

✔ CATCH catches errors.

✔ COMMIT saves data.

✔ ROLLBACK restores previous state.