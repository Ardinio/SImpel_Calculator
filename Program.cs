using System;

namespace SImpel_Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Sum Calculator!");

        int num1 = ReadIntegerInput("Enter the first number: ");
        int num2 = ReadIntegerInput("Enter the second number: ");

        int sum = num1 + num2;
        Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, sum);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    static int ReadIntegerInput(string message)
    {
        int number;
        bool isValidInput = false;

        do
        {
            Console.Write(message);
            string? input = Console.ReadLine();

            isValidInput = int.TryParse(input, out number);

            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        while (!isValidInput);

        return number;
    }
}

