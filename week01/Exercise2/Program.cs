using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        int x = int.Parse(gradePercentage);
        string letter = "";

        if (x >= 90)
        {
            letter = "A";
        }

        else if (x >= 80)
        {
            letter = "B";
        }

        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "d";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (x >= 70)
        {
            Console.WriteLine("Yay! You passed the class!");
        }

        else
        {
            Console.WriteLine("Sorry! Remember what you've learned and try again! You've got this!");
        }
    }
}