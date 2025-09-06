using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayResult();
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static string PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        return userInput;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult()
    {
        // Display welcome message
        DisplayWelcome();

        // Prompts for user name
        string userName = PromptUserName();

        // PromptUserName for user's favorite number, then converts it from a sting to an int
        string userInput = PromptUserNumber();
        int number = int.Parse(userInput);
        // Squares the user's favorite number
        int result = SquareNumber(number);

        Console.WriteLine($"{userName}, the square of your number is {result}");
    }
    
}