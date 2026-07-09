using System;

interface IPrint
{
    void Print();
}

interface IScan
{
    void Scan();
}

class Printer : IPrint
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }
}

class AllInOnePrinter : IPrint, IScan
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
}

class Program
{
    static void Main()
    {
        Printer printer = new Printer();
        printer.Print();

        AllInOnePrinter allInOne = new AllInOnePrinter();
        allInOne.Print();
        allInOne.Scan();
    }
}