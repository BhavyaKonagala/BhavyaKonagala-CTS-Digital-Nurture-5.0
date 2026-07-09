# Heap Sort

## Objective

Understand the Heap Sort algorithm and learn how it uses a Binary Heap to sort elements efficiently.

---

## Overview

Heap Sort is a comparison-based sorting algorithm that first builds a Max Heap and then repeatedly removes the largest element to produce a sorted array.

It provides consistent O(n log n) performance.

---

## Algorithm

1. Build a Max Heap.
2. Swap the root with the last element.
3. Reduce the heap size.
4. Heapify the root.
5. Repeat until the array is sorted.

---

## Time Complexity

| Case | Complexity |
|------|------------|
| Best | O(n log n) |
| Average | O(n log n) |
| Worst | O(n log n) |

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
Sorted Array:

5 6 7 11 12 13
```