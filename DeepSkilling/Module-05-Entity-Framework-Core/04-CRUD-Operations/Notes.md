# CRUD Operations

## Create

Adds a new entity to the database.

Example

```csharp
context.Students.Add(student);
context.SaveChanges();
```

---

## Read

Retrieves records from the database.

Example

```csharp
context.Students.ToList();
```

---

## Update

Modifies an existing entity.

Example

```csharp
student.Age = 21;
context.SaveChanges();
```

---

## Delete

Removes an entity from the database.

Example

```csharp
context.Students.Remove(student);
context.SaveChanges();
```

---

## SaveChanges()

Commits all pending changes to the database.

---

## Advantages

- Easy CRUD implementation
- Automatic SQL generation
- Strongly typed entities
- Change tracking support