# Triggers and Cursors Notes

## Trigger

A Trigger is a special Stored Procedure that executes automatically when an INSERT, UPDATE or DELETE operation occurs.

Syntax

CREATE TRIGGER TriggerName
ON TableName
AFTER INSERT
AS
BEGIN
    SQL Statements
END

---

## Cursor

A Cursor processes one row at a time.

Steps

1. Declare Cursor
2. Open Cursor
3. Fetch Records
4. Close Cursor
5. Deallocate Cursor

---

## Advantages

Trigger

- Automatic Execution
- Data Auditing
- Logging

Cursor

- Row-by-row processing
- Useful for complex operations

---

## Key Points

✔ Trigger runs automatically.

✔ Cursor processes records individually.

✔ Always CLOSE and DEALLOCATE a Cursor.