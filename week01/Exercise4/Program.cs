uning System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a list of numbers, type 0 when finished.");
        List<int> number = new List<int>();

        int input = -1;

        while (input != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();

            input = int.Parse(userInput);

            if (input != 0)
            {
                numbers.Add(input);
            }
        }
    }
}