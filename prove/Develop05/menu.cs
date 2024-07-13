class Menu
{
    public int DisplayMenu(int score, Goals goals)
    {
        int userInput = 0;

        while (userInput < 1 || userInput > 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {score} points.");
            Console.WriteLine($"You are on level {goals.GetLevel()}.");
            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());
        }

        return userInput;
    }
    public int DisplayGoalMenu()
    {
        Console.WriteLine();
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int userInput = int.Parse(Console.ReadLine());

        return userInput;
    }
}
