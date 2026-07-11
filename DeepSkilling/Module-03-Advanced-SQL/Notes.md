# Module 03 - Advanced SQL Notes

## SQL Server

SQL Server is a Relational Database Management System (RDBMS) developed by Microsoft.

It stores, manages and retrieves data using T-SQL (Transact-SQL).

---

# 1. DDL and DML

## DDL Commands

- CREATE
- ALTER
- DROP
- TRUNCATE

DDL modifies database structure.

---

## DML Commands

- INSERT
- UPDATE
- DELETE
- SELECT

DML manipulates table data.

---

# 2. Joins and Subqueries

## Joins

- INNER JOIN
- LEFT JOIN
- RIGHT JOIN

Joins retrieve data from multiple tables.

---

## Subqueries

A query written inside another SQL query.

Types

- Scalar
- Multiple Row
- Nested

---

# 3. Views and Indexes

## View

A virtual table created from one or more tables.

Advantages

- Security
- Simplicity
- Reusability

---

## Index

Improves query performance.

Types

- Clustered
- Non-Clustered

---

# 4. Window Functions

Functions

- OVER()
- ROW_NUMBER()
- RANK()
- DENSE_RANK()
- PARTITION BY

Used for ranking and analytical queries.

---

# 5. CTE

Common Table Expression.

Uses

- Readability
- Recursion
- Hierarchical Queries

Recursive CTE is used for tree-like data.

---

# 6. Stored Procedures and UDFs

Stored Procedures

- Reusable SQL programs.

Functions

- Scalar Functions
- Table Valued Functions

Advantages

- Better Performance
- Reusability
- Security

---

# 7. Triggers and Cursors

Trigger

Automatically executes after INSERT, UPDATE or DELETE.

Cursor

Processes records one row at a time.

Steps

1. Declare
2. Open
3. Fetch
4. Close
5. Deallocate

---

# 8. Exception Handling and Transactions

TRY...CATCH

Used for runtime error handling.

Transactions

Commands

- BEGIN TRANSACTION
- COMMIT
- ROLLBACK

ACID Properties

A - Atomicity

C - Consistency

I - Isolation

D - Durability

---

# 9. MERGE, PIVOT and UNPIVOT

MERGE

Synchronizes data between two tables.

PIVOT

Converts rows into columns.

UNPIVOT

Converts columns into rows.

---

# Key Takeaways

✔ SQL Server is Microsoft's RDBMS.

✔ DDL changes structure.

✔ DML changes data.

✔ Joins combine tables.

✔ Views simplify queries.

✔ Indexes improve performance.

✔ Window Functions perform analytical calculations.

✔ CTE simplifies complex queries.

✔ Stored Procedures improve reusability.

✔ Triggers automate operations.

✔ Cursors process one row at a time.

✔ Transactions maintain data integrity.

✔ MERGE synchronizes data.

✔ PIVOT transforms rows into columns.

✔ UNPIVOT transforms columns into rows.