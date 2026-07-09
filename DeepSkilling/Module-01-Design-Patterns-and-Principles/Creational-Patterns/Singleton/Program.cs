using System;

class Singleton
{
    private static Singleton instance;

    private Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }

        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("Singleton Object Created");
    }
}

class Program
{
    static void Main()
    {
        Singleton obj1 = Singleton.GetInstance();
        Singleton obj2 = Singleton.GetInstance();

        obj1.ShowMessage();

        if (obj1 == obj2)
        {
            Console.WriteLine("Both objects are the same instance.");
        }
    }
}