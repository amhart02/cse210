using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //create stuff 
        int userInput = 0;
        Menu menu = new Menu();

        //main while loop
        while (userInput > 1 || userInput < 4)
        {
            //create user input
            userInput = menu.DisplayMenu();

            //breathing activity
            if (userInput == 1)
            {
                Console.Clear();
                //create stuff 
                int activityDuration = 0;
                Breathing breathing = new Breathing("Welcome to the Breathing Activity.", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on breathing.", "Well Done!!", activityDuration, "Breathing");

                //display start and description messages
                Console.WriteLine();
                breathing.DisplayStartMessage();
                Console.WriteLine();
                breathing.DisplayDescription();
                Console.WriteLine();

                //get duration from user
                activityDuration = breathing.GetDuration();
                breathing.SetAttribute(activityDuration);
                Console.WriteLine();
                Console.Write("How many seconds would you like to breathe in? ");
                int breatheIn = int.Parse(Console.ReadLine());
                Console.Write("How many seconds would you like to breathe out?");
                int breatheOut = int.Parse(Console.ReadLine());
                // create time
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(activityDuration);

                //display get ready 
                breathing.GetReady();
                breathing.Spinner();

                //loop through breathe in and out
                while (DateTime.Now < futureTime)
                {
                    breathing.BreatheIn(breatheIn);
                    breathing.BreatheOut(breatheOut);
                } 

                //display end message
                breathing.DisplayFinishMessage();
                breathing.Spinner();

                //display duration
                breathing.DisplayDuration();
                breathing.Spinner();
            }
            // reflecting activity
            else if (userInput == 2)
            {
                Console.Clear();
                //create stuff 
                int activityDuration = 0;
                Reflection reflection = new Reflection("Think of a time when you stood up for someone else.Think of a time when you did something really difficult.Think of a time when you helped someone in need.Think of a time when you did something truly selfless.", "Why was this experience meaningful to you?Have you ever done anything like this before?How did you get started?How did you feel when it was complete?What made this time different than other times when you were not as successful?What is your favorite thing about this experience?What could you learn from this experience that applies to other situations?What did you learn about yourself through this experience?How can you keep this experience in mind in the future?", "Welcome to the Reflection Activity.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Well Done!!", activityDuration, "Reflecting");

                //display start and description messages
                reflection.DisplayStartMessage();
                Console.WriteLine();
                reflection.DisplayDescription();
                Console.WriteLine();

                //get duration from user
                activityDuration = reflection.GetDuration();
                reflection.SetAttribute(activityDuration);

                //display get ready 
                reflection.GetReady();
                reflection.Spinner();

                //display prompt
                reflection.DisplayPrompt();

                //display questions 
                reflection.DisplayQuestions(activityDuration);

                //display end message
                reflection.DisplayFinishMessage();
                reflection.Spinner();

                //display duration
                reflection.DisplayDuration();
                reflection.Spinner();
            }
            //listing activity
            else if (userInput == 3)
            {
                Console.Clear();
                //create stuff 
                int activityDuration = 0;
                Listing listing = new Listing("Who are people that you appreciate?What are personal strengths of yours?Who are people that you have helped this week?When have you felt the Holy Ghost this month?Who are some of your personal heroes?", "Welcome to the Listing Activity.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Well Done!!", activityDuration, "Listing");

                //display start and description messages
                listing.DisplayStartMessage();
                Console.WriteLine();
                listing.DisplayDescription();
                Console.WriteLine();

                //get duration from user
                activityDuration = listing.GetDuration();
                listing.SetAttribute(activityDuration);

                //display get ready 
                listing.GetReady();
                listing.Spinner();
                //display prompt
                listing.DisplayPromptWrite(activityDuration);

                //display end message
                listing.DisplayFinishMessage();
                listing.Spinner();

                //display duration
                listing.DisplayDuration();
                listing.Spinner();
            }
            //user quit
            else if (userInput == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please input a number 1-4.");
                break;
            }
        }
    }
}