using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response == "yes")
        {
            Console.Write("Would you like to play again? ");
            response = Console.ReadLine();
        }

        Random randomGenerator = new Random();
        int secretNumber = randomGenerator.Next(1, 11);

        do
        {
            Console.Write("What is the magic number? ")
            secretNumber = Console.ReadLine();
        } while (secretNumber == 0);


    }
}