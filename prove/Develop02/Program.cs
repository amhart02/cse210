using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //define varibles
        string userChoice = "";
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        List<string> prompts = new List<string>{"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
        //Display the menu with a while loop and if statement
        do {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please choose an option (1-5):");
            Console.WriteLine("1-Write a new entry");
            Console.WriteLine("2-Display the journal");
            Console.WriteLine("3-Load the journal");
            Console.WriteLine("4-Save the journal");
            Console.WriteLine("5-Quit");
            userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Random random = new Random();
                int randomIndex = random.Next(prompts.Count);
                string randomPrompt = prompts[randomIndex];
                Entry entry = new Entry();
                entry._date = dateText;
                entry._prompt = randomPrompt;
                Console.WriteLine(entry._prompt);
                entry._response = Console.ReadLine();
            }
            else if (userChoice == "2")
            {
                
            }
            else if (userChoice == "3")
            {

            }
            else if (userChoice == "4")
            {

            }
            else 
            {
                Console.WriteLine("Please choose a number 1-5.");
            }
        } while (userChoice != "5");

        
    }
}