using System;

class Program
{
    static void Main(string[] args)
    {
        //This is exercise 2

        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int score = int.Parse(valueFromUser);

        string letter = "";

        if (score >= 90)

        {
            letter = "A";
            Console.WriteLine($"You made an {letter}. Congratulations, you passed the course!!");
        }
        else if (score >= 80)
        {
            letter = "B";
            Console.WriteLine($"You made a {letter}. Congratulations, you passed the course!!");
        }
        else if (score >= 70)
        {
            letter = "C";
            Console.WriteLine($"You made a {letter}. Congratulations, you passed the course!!");
        }
        else if (score >= 60)
        {
            letter = "D";
            Console.WriteLine($"You made a {letter}. Sorry, better luck in your next attempt!!");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"You made an {letter}. Sorry, better luck in your next attempt!!");
        }
    }
}