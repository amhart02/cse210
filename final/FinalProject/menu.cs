class Menu
{
    public User DisplayLogIn()
    {
        Console.Write("Are you a GoldStar Member (yes/no)? ");
        string input = Console.ReadLine().ToLower();
        bool goldStar = input == "yes";

        Console.WriteLine("Please Log in:");
        Console.Write("First and last name: ");
        string name = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        Console.Write("User ID Number: ");
        int userID = int.Parse(Console.ReadLine());

        if (goldStar)
        {
            Console.Write("GoldStar Member ID: ");
            int goldStarID = int.Parse(Console.ReadLine());

            GoldStar goldStarUser = new GoldStar(name, email, password, userID, goldStarID);
            return goldStarUser;
        }
        else
        {
            User user = new User(name, email, password, userID);
            return user;
        }
    }
}
