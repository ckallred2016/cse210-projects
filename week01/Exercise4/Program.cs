using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> number = new List<int>();

        int input = -1;

        while (input != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();

            input = int.Parse(userInput);

            if (input != 0)
            {
                number.Add(input);
            }
        }

        int sum = number.Sum();
        double average = number.Average();
        int largest = number.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}