using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1; // initialize userNumber to -1
        while (userNumber != 0) // keep asking until user enters 0
        {
            Console.Write("Enter a number, or enter 0 to stop: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0) // don't add 0 to the list
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count; // cast to float to avoid integer division
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0]; // assume the first number is the largest

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}