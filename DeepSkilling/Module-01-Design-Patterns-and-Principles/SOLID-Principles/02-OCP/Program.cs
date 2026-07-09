using System;

abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double Radius;

    public Circle(double r)
    {
        Radius = r;
    }

    public override double Area()
    {
        return 3.14 * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Length, Width;

    public Rectangle(double l, double w)
    {
        Length = l;
        Width = w;
    }

    public override double Area()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main()
    {
        Shape c = new Circle(5);
        Shape r = new Rectangle(4, 6);

        Console.WriteLine("Circle Area: " + c.Area());
        Console.WriteLine("Rectangle Area: " + r.Area());
    }
}