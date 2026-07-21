# Performance Optimizations

## AsNoTracking()

Disables change tracking for read-only queries.

Example

```csharp
context.Students.AsNoTracking();
```

Benefits

- Faster queries
- Lower memory usage

---

# Batch Operations

Insert multiple records together.

Example

```csharp
context.Students.AddRange(list);
```

---

# RowVersion

Used for optimistic concurrency.

```csharp
[Timestamp]
public byte[]? RowVersion { get; set; }
```

---

# Best Practices

- Use AsNoTracking() for read-only data.
- Retrieve only required columns.
- Avoid unnecessary queries.
- Use AddRange() for multiple inserts.
- Keep DbContext lifetime short.
- Use async methods in real applications.
- Create indexes for frequently searched columns.
- Avoid loading unnecessary related data.

---

# Key Takeaways

✔ Faster Queries

✔ Reduced Memory Usage

✔ Better Scalability

✔ Improved Database Performance

✔ Optimistic Concurrency Support