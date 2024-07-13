using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        Menu menu = new Menu();
        Goals goals = new Goals();

        //main while loop
        while (userInput > 0 || userInput < 6)
        {
            userInput = menu.DisplayMenu(goals.GetScore(), goals);

            //create new goal
            if (userInput == 1)
            {
                Menu goalMenu = new Menu();
                int goalChoice = goalMenu.DisplayGoalMenu();

                //simple goal
                if (goalChoice == 1)
                {
                    Console.WriteLine();
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points assciated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    Simple simple = new Simple(name, description, points, "SimpleGoal", false);
                    goals.AddGoal(simple);
                }
                //eternal goal
                else if (goalChoice == 2)
                {
                    Console.WriteLine();
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points assciated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    Eternal eternal = new Eternal(name, description, points, "EternalGoal");
                    goals.AddGoal(eternal);
                }
                //checklist goal
                else if (goalChoice == 3)
                {
                    Console.WriteLine();
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points assciated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int occurences = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    Checklist checklist = new Checklist(name, description, points, "ChecklistGoal", occurences, bonus, 0, false);
                    goals.AddGoal(checklist);
                }
                else
                {
                    Console.WriteLine("Please write a number 1-3");
                }
            }

            //list goals
            else if (userInput == 2)
            {
                goals.DisplayGoals();
            }

            //save goals
            else if (userInput == 3)
            {
                goals.SaveToFile();
            }

            //Load goals
            else if (userInput == 4)
            {
                List<Goal> loadedGoals = Goals.ReadFromFile();
                goals.LoadGoals(loadedGoals);
            }

            //Record Event
            else if (userInput == 5)
            {
                Console.WriteLine();
                Console.Write("Which goal did you accomplish? ");
                int goalNumber = int.Parse(Console.ReadLine());
                Goal goalCompleted = goals.GetGoalByIndex(goalNumber - 1);
                int pointsEarned = goalCompleted.RecordEvent();
                goals.AddScore(pointsEarned);
                goalCompleted.CongradulatePoints(goalCompleted);
                Console.WriteLine($"You now have {goals.GetScore()} points.");
                goals.ChangeNumberGoalsCompleted();
                int goalsCompleted = goals.GetNumberGoalsCompleted();
                if (goalsCompleted == 3)
                {
                    Console.WriteLine("Congratulations, you are now level 2!");
                    goals.LevelUp();
                }
                else if (goalsCompleted == 6)
                {
                    Console.WriteLine("Congratulations, you are now level 3!");
                    goals.LevelUp();
                }
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