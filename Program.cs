using System;

namespace SImpel_Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Calculator App!");

        int num1 = ReadIntegerInput("Enter the first number: ");
        int num2 = ReadIntegerInput("Enter the second number: ");

        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int operationChoice = ReadOperationChoice();

        int result = PerformOperation(num1, num2, operationChoice);

        int sum = num1 + num2;
        
        Console.WriteLine("The result is: " + result);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    static int ReadIntegerInput(string message)
    {
        int number;
        bool isValidInput = false;

        // This loop will run atlest one time because the condition is checked after it has been executed.
        do
        {
            Console.Write(message);
            string? input = Console.ReadLine();

            // Will convert the input to an int and check if it is an number.
            isValidInput = int.TryParse(input, out number);

            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        while (!isValidInput);

        return number;
    }

    static int ReadOperationChoice()
    {
        int operationChoice;
        bool isValidChoice = false;

        do
        {
            string? input = Console.ReadLine();
            isValidChoice = int.TryParse(input, out operationChoice);

            if (!isValidChoice || operationChoice < 1 || operationChoice > 4)
            {
                Console.WriteLine("Invalid input. Please enter a valid operation choice (1-4).");
            }
        }
        while (!isValidChoice || operationChoice < 1 || operationChoice > 4);

        return operationChoice;
    }

    static int PerformOperation(int num1, int num2, int operationChoice)
    {
        int result = 0;

        switch (operationChoice)
        {
            case 1: // Addition
                result = num1 + num2;
                break;
            case 2: // Subtraction
                result = num1 - num2;
                break;
            case 3: // Multiplication
                result = num1 * num2;
                break;
            case 4: // Division
                if (num2 != 0)
                {
                    result = num1 / num2; 
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                break;
        }

        return result;
    }
}