using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        int userAge = -1;

        while (userAge < 0 || userAge > 120 )
        {
            Console.WriteLine("Please input your age (0-120): ");
            userAge = int.Parse(Console.ReadLine());
        }

        int userAge2 = 3249724;

        do
        {
            Console.WriteLine("Please input your age (0-120): ");
            userAge2 = int.Parse(Console.ReadLine());
        } while (userAge2 < 0 || userAge2 > 120 );

        List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5};
        List<string> myNames = new List<string> {"Betty"};

        myNames.Add("Bob");
        myNumbers.Add(6);

        foreach (string name in myNames)
        {
            Console.WriteLine(name);
        }

        //area.ToString("F3")
    }
}