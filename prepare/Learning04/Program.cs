using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Roberto Rodriguez", "Fractions");
        Console.WriteLine(assignment1.GetSummary());

        Math math1 = new Math("Section 7.3", "Problems 8-19", "Roberto Rodriguez", "Fractions");
        Console.WriteLine(math1.GetHomeworkList());

        Writing writing1 = new Writing("The Causes of World War II by Mary Waters", "Mary Waters", "European History");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}