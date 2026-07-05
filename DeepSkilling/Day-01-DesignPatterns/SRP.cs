using System;

class Invoice
{
    public void CalculateTotal()
    {
        Console.WriteLine("Calculating invoice total...");
    }
}

class InvoicePrinter
{
    public void PrintInvoice()
    {
        Console.WriteLine("Printing invoice...");
    }
}

class Program
{
    static void Main()
    {
        Invoice invoice = new Invoice();
        invoice.CalculateTotal();

        InvoicePrinter printer = new InvoicePrinter();
        printer.PrintInvoice();
    }
}