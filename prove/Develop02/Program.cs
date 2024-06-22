using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //define varibles
        string userChoice = "";
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        List<string> prompts = new List<string>{"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
        List<string> affirmations = new List<string>{"I am worthy of love and respect.","I believe in myself and my abilities.", "I am confident in my decisions.", "I deserve happiness and success.", "I am proud of who I am becoming.", "I am enough just as I am.", "I am capable of achieving my dreams."};
        Journal journal1 = new Journal();
        //make random affirmation
        Random random2 = new Random();
        int randomIndex2 = random2.Next(affirmations.Count);
        string randomAffirmation = affirmations[randomIndex2];
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
            //write a new entry
            if (userChoice == "1")
            {
                //make random prompt
                Random random = new Random();
                int randomIndex = random.Next(prompts.Count);
                string randomPrompt = prompts[randomIndex];
                //create new entry
                Entry entry1 = new Entry();
                entry1._date = dateText;
                entry1._prompt = randomPrompt;
                Console.WriteLine();
                Console.WriteLine(entry1._prompt);
                entry1._response = Console.ReadLine();
                Console.WriteLine();
                //add to journal 
                journal1._entries.Add(entry1);  
            }
            //display the journal
            else if (userChoice == "2")
            {
                Console.WriteLine();
                journal1.DisplayJournal();
                Console.WriteLine($"Your positive affirmation: {randomAffirmation} :))))");
                Console.WriteLine();
            }
            //load the journal
            else if (userChoice == "3")
            {
                Console.WriteLine();
                List<Entry> newEntries = Journal.ReadFromFile();
                foreach (Entry entry in newEntries)
                {
                    Console.WriteLine(entry);
                }
            }
            //save the journal
            else if (userChoice == "4")
            {
                Journal.SaveToFile(journal1);
                Console.WriteLine();
                Console.WriteLine("Saved to file.");
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine("Please choose a number 1-5.");
                Console.WriteLine();
            }
        } while (userChoice != "5");        
    }
}