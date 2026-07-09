using System;

interface ICommand
{
    void Execute();
}

class Light
{
    public void On()
    {
        Console.WriteLine("Light ON");
    }
}

class LightCommand : ICommand
{
    private Light light = new Light();

    public void Execute()
    {
        light.On();
    }
}

class Program
{
    static void Main()
    {
        ICommand command = new LightCommand();
        command.Execute();
    }
}