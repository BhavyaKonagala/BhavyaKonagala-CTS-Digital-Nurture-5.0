using System;

class Subscriber
{
    public void Update()
    {
        Console.WriteLine("Notification Received");
    }
}

class Publisher
{
    public event Action Notify;

    public void Publish()
    {
        Notify?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        publisher.Notify += subscriber.Update;

        publisher.Publish();
    }
}