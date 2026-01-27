using System;

class Program
{
    static void Main(string[] args)
    {

        // You program allows the user to choose  number of words hidden per round
        // (difficult control), helping users to memorize at their own pace.

        // The program hides ONLY words that are not
        // already hidden, preventing wasted attempts.

        Console.WriteLine("Choose a difficulty level:");
        Console.WriteLine("1. Easy");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Hard");
        Console.Write("Selection: ");

        string difficultyChoice = Console.ReadLine();
        int wordsToHide = 3; // default (medium)

        if (difficultyChoice == "1")
        {
            wordsToHide = 1;
        }
        else if (difficultyChoice == "2")
        {
            wordsToHide = 3;
        }
        else if (difficultyChoice == "3")
        {
            wordsToHide = 5;
        }


        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text =
            "Trust in the Lord with all thine heart and lean not unto thine own understanding. " +
            "In all thy ways acknowledge him and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);
        Random random = new Random();

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(wordsToHide, random);
        }
    }
}
