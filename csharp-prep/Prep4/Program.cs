using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int> ();
        int newNumber = 0;
        int totalNumber = -1;
        int sum = 0;
        int largestNumber = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do {
        newNumber = int.Parse(Console.ReadLine());
        numbers.Add(newNumber);
        totalNumber += 1;
        } while (newNumber != 0); 

        foreach (int number in numbers) 
        {
            sum += number;
            if (number > largestNumber) 
            {
                largestNumber = number;
            }
        }

        Console.WriteLine(totalNumber);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/totalNumber}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}