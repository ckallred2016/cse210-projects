using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }

        else if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }

        else
        {
            Console.WriteLine("You guessed it!");
        }

        // string response = "yes";

        // while (response == "yes")
        // {
        //     Console.Write("Would you like to play again? ");
        //     response = Console.ReadLine();
        // }

        // Random randomGenerator = new Random();
        // int secretNumber = randomGenerator.Next(1, 11);

        // do
        // {
        //     Console.Write("What is the magic number? ")
        //     secretNumber = Console.ReadLine();
        // } while (secretNumber == 0);


    }
}