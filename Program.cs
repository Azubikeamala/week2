// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Task 1: Ask the user to enter four numbers, three digits each
        Console.WriteLine("Please enter four three-digit numbers:");

        // Task 2: Save each number as four separate string variables
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        string num3 = Console.ReadLine();
        string num4 = Console.ReadLine();

        // Task 3: Convert all string inputs into double variables
        double number1 = Convert.ToDouble(num1);
        double number2 = Convert.ToDouble(num2);
        double number3 = Convert.ToDouble(num3);
        double number4 = Convert.ToDouble(num4);

        // Task 4: Add the first three numbers and store the result in an integer variable called "firstThree"
        int firstThree = (int)(number1 + number2 + number3);

        // Task 5: Add all numbers and store the result in an integer variable called "totalSum"
        int totalSum = (int)(number1 + number2 + number3 + number4);

        // Task 6: Multiply the last two numbers and store the result in an integer variable called "lastTwo"
        int lastTwo = (int)(number2 * number3);

        // Task 7: Add the variables "totalSum" and "lastTwo", saving the result as an integer variable
        int totalWithLastTwo = totalSum + lastTwo;

        // Task 8: Subtract the fourth number from the "lastTwo" variable
        int lastTwoMinusFourth = lastTwo - (int)number4;

        // Task 9: Output ALL results to the console
        Console.WriteLine($"\nResults:");
        Console.WriteLine($"Sum of the first three numbers (firstThree): {firstThree}");
        Console.WriteLine($"Total sum of all numbers (totalSum): {totalSum}");
        Console.WriteLine($"Product of the last two numbers (lastTwo): {lastTwo}");
        Console.WriteLine($"Sum of totalSum and lastTwo: {totalWithLastTwo}");
        Console.WriteLine($"lastTwo minus the fourth number: {lastTwoMinusFourth}");
    }
}

