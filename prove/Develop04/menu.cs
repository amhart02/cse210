class Menu 
{
    public int DisplayMenu()
    {
        int userInput = 0;

        while (userInput < 1 || userInput > 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Please choose a number 1-4:");

            try 
            {
                userInput = int.Parse(Console.ReadLine());
            }
            catch
            {
                
            }
        }
        return userInput;
    }
}