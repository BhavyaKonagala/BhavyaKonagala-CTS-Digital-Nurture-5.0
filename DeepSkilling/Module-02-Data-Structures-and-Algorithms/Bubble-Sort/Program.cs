using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

        int n = numbers.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Array:");

        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}