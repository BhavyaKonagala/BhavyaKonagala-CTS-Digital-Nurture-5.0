# Creating Database Model

## Entity

An entity represents a database table.

Example

- Student
- Department

---

## Primary Key

Uniquely identifies each record.

Example

```csharp
public int StudentId { get; set; }
```

---

## Foreign Key

Connects two tables.

Example

```csharp
public int DepartmentId { get; set; }
```

---

## Navigation Property

Used to navigate between related entities.

Example

```csharp
public Department? Department { get; set; }
```

---

## Relationship

Department (1)

↓

Student (Many)

---

## Code First

Create C# classes first.

EF Core automatically creates database tables.