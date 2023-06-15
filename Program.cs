using System;

namespace SImpel_Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Sum Calculator!");

        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, sum);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

