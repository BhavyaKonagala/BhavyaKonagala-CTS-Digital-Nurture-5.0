# Interface Segregation Principle (ISP)

## Definition

A class should not be forced to implement methods it does not need.

## Purpose

Create multiple small interfaces instead of one large interface.

## Example Used

Interfaces:

- IPrint
- IScan

Classes:

- Printer
- AllInOnePrinter

The Printer class only prints, while the AllInOnePrinter can both print and scan.

## Real-World Example

A multifunction printer can:

- Print
- Scan
- Fax

A normal printer only needs the Print functionality.

Instead of forcing every printer to implement Scan and Fax methods, separate interfaces are created.

## Advantages

- Reduces unnecessary code
- Improves flexibility
- Easier to maintain
- Encourages reusable interfaces

## Key Takeaway

Design small, focused interfaces so that classes only implement what they actually need.