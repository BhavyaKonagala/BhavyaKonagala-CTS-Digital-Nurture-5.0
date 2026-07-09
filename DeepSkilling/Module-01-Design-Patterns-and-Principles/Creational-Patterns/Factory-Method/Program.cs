using System;

interface IAnimal
{
    void Speak();
}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Dog says: Bow Bow");
    }
}

class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Cat says: Meow");
    }
}

class AnimalFactory
{
    public static IAnimal GetAnimal(string animal)
    {
        if (animal == "Dog")
            return new Dog();

        return new Cat();
    }
}

class Program
{
    static void Main()
    {
        IAnimal animal = AnimalFactory.GetAnimal("Dog");
        animal.Speak();
    }
}