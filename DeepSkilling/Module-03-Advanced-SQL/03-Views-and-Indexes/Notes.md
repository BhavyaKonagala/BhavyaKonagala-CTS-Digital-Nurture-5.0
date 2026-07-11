# Views and Indexes Notes

## View

A View is a virtual table.

Syntax

CREATE VIEW ViewName
AS
SELECT ...

Advantages

- Security
- Simplicity
- Reusable Queries

---

## Index

Indexes improve search performance.

Types

- Clustered
- Non-Clustered

Syntax

CREATE INDEX IndexName
ON TableName(ColumnName);

---

## Difference

View

- Virtual Table
- Stores Query

Index

- Improves Performance
- Stores Data Structure

---

## Key Points

✔ View does not store data.

✔ Index speeds up searching.

✔ Every Primary Key creates a Clustered Index by default.