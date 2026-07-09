using System;

class House
{
    public string Walls;
    public string Roof;

    public void Show()
    {
        Console.WriteLine(Walls);
        Console.WriteLine(Roof);
    }
}

class HouseBuilder
{
    House house = new House();

    public HouseBuilder BuildWalls()
    {
        house.Walls = "Walls Built";
        return this;
    }

    public HouseBuilder BuildRoof()
    {
        house.Roof = "Roof Built";
        return this;
    }

    public House GetHouse()
    {
        return house;
    }
}

class Program
{
    static void Main()
    {
        House house = new HouseBuilder()
            .BuildWalls()
            .BuildRoof()
            .GetHouse();

        house.Show();
    }
}