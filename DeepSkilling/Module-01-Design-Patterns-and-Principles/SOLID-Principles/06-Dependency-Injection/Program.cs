using System;

interface IService
{
    void Serve();
}

class Service : IService
{
    public void Serve()
    {
        Console.WriteLine("Service Executed");
    }
}

class Client
{
    private IService service;

    public Client(IService service)
    {
        this.service = service;
    }

    public void Start()
    {
        service.Serve();
    }
}

class Program
{
    static void Main()
    {
        IService service = new Service();

        Client client = new Client(service);

        client.Start();
    }
}