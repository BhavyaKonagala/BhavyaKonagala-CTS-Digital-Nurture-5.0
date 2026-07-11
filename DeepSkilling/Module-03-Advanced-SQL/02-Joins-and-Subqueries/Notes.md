# Joins and Subqueries Notes

## INNER JOIN

Returns only matching rows.

---

## LEFT JOIN

Returns all rows from the left table and matching rows from the right table.

---

## RIGHT JOIN

Returns all rows from the right table.

---

## Subquery

A query inside another query.

Example:

SELECT *
FROM Students
WHERE StudentID IN
(
SELECT StudentID
FROM Enrollments
);

---

## Scalar Subquery

Returns a single value.

Example:

SELECT MIN(StudentID)
FROM Students;

---

## Key Points

✔ INNER JOIN returns matching rows.

✔ LEFT JOIN returns all left rows.

✔ RIGHT JOIN returns all right rows.

✔ Subqueries simplify complex queries.