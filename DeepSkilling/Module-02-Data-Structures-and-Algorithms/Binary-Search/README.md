# Binary Search

## Objective

Understand the Binary Search algorithm and learn how it efficiently searches for an element in a sorted array.

---

## Overview

Binary Search is a searching algorithm that repeatedly divides the search space into two halves until the target element is found.

Unlike Linear Search, Binary Search works only on sorted data.

---

## Algorithm

1. Find the middle element.
2. Compare it with the target.
3. If equal, return the index.
4. If the target is greater, search the right half.
5. Otherwise, search the left half.
6. Repeat until the element is found or the search space becomes empty.

---

## Time Complexity

| Case | Complexity |
|------|------------|
| Best Case | O(1) |
| Average Case | O(log n) |
| Worst Case | O(log n) |

---

## Space Complexity

O(1)

---

## Technologies Used

- C#
- .NET Console Application

---

## Expected Output

```
Element found at index: 4
```