using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bonjour Tout Le Monde.");

        Person person1 = new Person("Bob", "Billy", 34, 210);
        Console.WriteLine(person1.PersonInformation());

        Fireman fireman1 = new Fireman("EMT and Parametic", "Betty", "Billy", 34, 210);

        Console.WriteLine(fireman1.PersonInformation());
        Console.WriteLine(fireman1.FiremanInformation());
    }
}