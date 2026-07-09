using System;

class Program
{
    static void Main()
    {
        int n = 5;

        Console.WriteLine("Printing numbers from 1 to " + n);

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Time Complexity: O(n)");
    }
}