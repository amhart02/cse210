using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());


        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else if (gradePercentage < 60)
        {
            letter = "F";
        }
        else 
        {
            Console.WriteLine("Please enter a number 1-100.");
        }
        
        Console.WriteLine($"You have a/an {letter}");

        if (gradePercentage > 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else if (gradePercentage < 70)
        {
            Console.WriteLine("You have failed. You got it next time!");
        }
    }
}