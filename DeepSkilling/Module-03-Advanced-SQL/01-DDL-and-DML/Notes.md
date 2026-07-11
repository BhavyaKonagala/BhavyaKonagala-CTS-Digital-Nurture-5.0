# DDL and DML Notes

## SQL Server

Microsoft SQL Server is a Relational Database Management System (RDBMS).

It stores and manages data using SQL (Structured Query Language).

---

## DDL (Data Definition Language)

DDL commands define or modify database objects.

Commands:

- CREATE
- ALTER
- DROP
- TRUNCATE

### CREATE

Creates a database or table.

Example

CREATE TABLE Students(...)

---

### ALTER

Modifies an existing table.

Example

ALTER TABLE Students ADD Email VARCHAR(100);

---

### DROP

Deletes the table permanently.

Example

DROP TABLE Students;

---

### TRUNCATE

Deletes all rows from a table but keeps the table structure.

---

## DML (Data Manipulation Language)

DML commands manipulate the data stored in tables.

Commands

- INSERT
- UPDATE
- DELETE
- SELECT

### INSERT

Adds new rows.

### UPDATE

Modifies existing rows.

### DELETE

Deletes selected rows.

### SELECT

Retrieves data from a table.

---

## Difference

DDL

- Changes Structure
- Auto Commit

DML

- Changes Data
- Can be rolled back within a transaction

---

## Key Points

✔ CREATE creates objects.

✔ ALTER modifies objects.

✔ DROP removes objects.

✔ TRUNCATE removes all records.

✔ INSERT adds records.

✔ UPDATE modifies records.

✔ DELETE removes records.