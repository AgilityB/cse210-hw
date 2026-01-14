using System;

class Program
{
    static void Main(string[] args)
    {
        //Calling the Welcome message prompt    
        DisplayWelcomeMessage();

        //Defining my functions prompts

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);


        // Display the final result

        DisplayResult(userName, squaredNumber);
    }


    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string valueFromUser = Console.ReadLine();
        int number = int.Parse(valueFromUser);

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}.");
    }
}