# CTE and Recursive CTE Notes

## CTE

A Common Table Expression is a temporary named result set.

Syntax

WITH CTE_Name AS
(
SELECT ...
)

SELECT * FROM CTE_Name;

---

## Recursive CTE

A Recursive CTE references itself.

Uses

- Employee Hierarchy
- Organization Charts
- Folder Structures
- Tree Traversal

---

## Advantages

✔ Readable

✔ Reusable

✔ Easy to maintain

✔ Better than complex nested queries

---

## Key Points

- Starts with WITH
- Exists only during query execution
- Recursive CTE requires UNION ALL