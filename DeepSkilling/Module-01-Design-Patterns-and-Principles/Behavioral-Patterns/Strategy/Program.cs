using System;

interface IPayment
{
    void Pay();
}

class CreditCard : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paid using Credit Card");
    }
}

class UPI : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paid using UPI");
    }
}

class Program
{
    static void Main()
    {
        IPayment payment = new UPI();
        payment.Pay();
    }
}