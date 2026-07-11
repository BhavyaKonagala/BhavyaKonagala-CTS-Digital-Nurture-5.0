# Window Functions Notes

## OVER()

Defines the window over which a function operates.

Example

AVG(Salary) OVER()

---

## ROW_NUMBER()

Assigns a unique row number.

---

## RANK()

Assigns ranking with gaps.

Example

100
100
90

Ranks

1
1
3

---

## DENSE_RANK()

Assigns ranking without gaps.

Ranks

1
1
2

---

## PARTITION BY

Divides data into groups before applying window functions.

---

## Key Points

✔ OVER() is mandatory.

✔ ROW_NUMBER() gives unique numbering.

✔ RANK() skips numbers.

✔ DENSE_RANK() doesn't skip numbers.

✔ PARTITION BY groups data logically.