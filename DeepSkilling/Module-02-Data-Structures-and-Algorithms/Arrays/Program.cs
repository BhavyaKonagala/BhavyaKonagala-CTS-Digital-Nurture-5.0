using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Array Elements:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Total Elements: " + numbers.Length);
    }
}