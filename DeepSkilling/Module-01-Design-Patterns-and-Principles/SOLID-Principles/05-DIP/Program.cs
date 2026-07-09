using System;

interface IMessage
{
    void Send();
}

class Email : IMessage
{
    public void Send()
    {
        Console.WriteLine("Email Sent");
    }
}

class Notification
{
    private IMessage message;

    public Notification(IMessage msg)
    {
        message = msg;
    }

    public void Notify()
    {
        message.Send();
    }
}

class Program
{
    static void Main()
    {
        IMessage email = new Email();

        Notification notification = new Notification(email);

        notification.Notify();
    }
}