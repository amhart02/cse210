using System;

class Program
{
    static void Main(string[] args)
    {
        //create stuff 
        int userInput = 0;
        Menu menu = new Menu();
        Score score = new Score(0);

        //main while loop
        while (userInput > 1 || userInput < 4)
        {
             //create user input
            userInput = menu.DisplayMenu(score.DisplayScore());
            
            //create new goal
            if (userInput == 1)
            {
                Menu goalMenu = new Menu();
                int goalChoice = goalMenu.DisplayGoalMenu();

                //simple goal
                if (goalChoice == 1)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points assciated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    Simple simple = new Simple(name, description, false, points);
                    //save to the goal list in a way that's good to save in a file
                }
                //eternal goal
                else if (goalChoice == 2)
                {

                }
                //checklist goal
                else if (goalChoice == 3)
                {

                }
                else
                {
                    Console.WriteLine("Please write a number 1-3");
                }
            }
            
            //list goals
            else if (userInput == 2)
            {

            }

            //save goals
            else if (userInput == 3)
            {

            }

            //Load goals
            else if (userInput == 4)
            {

            }

            //Record Event
            else if (userInput == 5)
            {

            }

            //end program
            else if (userInput == 6)
            {
                break;
            }

            //make sure it's a number
            else
            {
                Console.WriteLine("Please write a number 1-6!");
            }
        }
    }
}