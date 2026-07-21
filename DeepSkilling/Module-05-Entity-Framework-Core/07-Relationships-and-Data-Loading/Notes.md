# Relationships and Data Loading

## One-to-Many Relationship

One department can have many students.

Department

↓

Students

---

## Primary Key

Uniquely identifies each record.

Example

DepartmentId

StudentId

---

## Foreign Key

Links two tables.

Example

DepartmentId

---

## Navigation Property

Allows navigation between related entities.

Example

public Department? Department { get; set; }

---

## Eager Loading

Loads related data together.

Example

```csharp
.Include(d => d.Students)
```

---

## Benefits

- Reduces additional queries
- Better performance
- Easy access to related data