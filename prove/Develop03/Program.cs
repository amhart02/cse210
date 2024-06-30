using System;

class Program
{
    static void Main(string[] args)
    {
        // create stuff
        Scripture scripture1 = new Scripture("Alma", 5, 33, 34, "Behold, he sendeth an invitation unto all men, for the arms of mercy are extended towards them, and he saith: Repent, and I will receive you. Yea, he saith: Come unto me and ye shall partake of the fruit of the tree of life; yea, ye shall eat and drink of the bread and the waters of life freely;");
        bool memorize = true;
        //create while loop
        while (memorize == true)
        {
            scripture1.ShowScripture();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                memorize = false;
            }
            if (scripture1.AllWordsHidden())
            {
                memorize = false;
            }

            scripture1.HideSomeWords();
        }
    }
}