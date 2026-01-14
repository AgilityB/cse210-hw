using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        // I adopted the while loop a do-while loop here instead
        int userNumber = -1;
        while (userNumber != 0)

        {
            Console.WriteLine("Enter number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            //Sum of total numbers, where number is not equal to 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } 

        // Part 1: Computing the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Computing the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the maximum number

        int max = numbers[0];
            
        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, then we have a new max!
                    max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    
    }
}