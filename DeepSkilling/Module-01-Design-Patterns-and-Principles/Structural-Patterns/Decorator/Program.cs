using System;

interface ICoffee
{
    void MakeCoffee();
}

class SimpleCoffee : ICoffee
{
    public void MakeCoffee()
    {
        Console.WriteLine("Simple Coffee");
    }
}

class MilkDecorator : ICoffee
{
    private ICoffee coffee;

    public MilkDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public void MakeCoffee()
    {
        coffee.MakeCoffee();
        Console.WriteLine("Added Milk");
    }
}

class Program
{
    static void Main()
    {
        ICoffee coffee = new MilkDecorator(new SimpleCoffee());
        coffee.MakeCoffee();
    }
}