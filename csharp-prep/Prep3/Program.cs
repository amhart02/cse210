using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int userGuess = 0;

        do {
        Console.Write("What is your guess?");
        userGuess = int.Parse(Console.ReadLine());
        if (userGuess == magicNumber) 
            {
                Console.WriteLine("You guessed it!");
            }
            else if (userGuess > magicNumber) 
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        } while (userGuess != magicNumber);
        
    }
}