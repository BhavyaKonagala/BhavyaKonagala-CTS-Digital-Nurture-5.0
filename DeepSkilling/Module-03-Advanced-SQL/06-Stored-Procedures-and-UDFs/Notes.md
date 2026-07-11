# Stored Procedures and UDF Notes

## Stored Procedure

A Stored Procedure is a precompiled SQL program stored inside the database.

Syntax

CREATE PROCEDURE ProcedureName
AS
BEGIN
    SQL Statements
END

Execute

EXEC ProcedureName

---

## Parameterized Procedure

Accepts input parameters.

Example

EXEC GetStudentByID 101

---

## User Defined Function

Reusable SQL function.

Types

- Scalar Function
- Table Valued Function

---

## Scalar Function

Returns a single value.

Example

dbo.GetBonus(Marks)

---

## Table Valued Function

Returns a table.

---

## Advantages

✔ Code Reusability

✔ Better Performance

✔ Easy Maintenance

✔ Security