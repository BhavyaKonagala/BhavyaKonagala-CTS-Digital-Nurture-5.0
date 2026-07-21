# LINQ Queries

## What is LINQ?

LINQ (Language Integrated Query) allows querying collections and databases using C# syntax.

---

## Where

Filters records.

```csharp
context.Students.Where(s => s.Age > 20);
```

---

## Select

Retrieves specific columns.

```csharp
context.Students.Select(s => s.Name);
```

---

## OrderBy

Sorts in ascending order.

```csharp
.OrderBy(s => s.Name)
```

---

## OrderByDescending

Sorts in descending order.

```csharp
.OrderByDescending(s => s.Marks)
```

---

## Aggregate Functions

Average

```csharp
Average()
```

Maximum

```csharp
Max()
```

Count

```csharp
Count()
```

---

## Advantages

- Strongly typed queries
- Readable syntax
- Compile-time checking
- Automatic SQL generation