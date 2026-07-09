using System;

class Invoice
{
    public void CalculateTotal()
    {
        Console.WriteLine("Calculating Invoice...");
    }
}

class InvoicePrinter
{
    public void PrintInvoice()
    {
        Console.WriteLine("Printing Invoice...");
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