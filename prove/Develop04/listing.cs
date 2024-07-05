class Listing : Activity
{
    private List<string> _listingPrompts = new List<string> ();
    public Listing(string prompts, string startMessage, string description, string finishMessage, int duration, string activityType) : base(startMessage, description, finishMessage, duration, activityType)
    {
        _listingPrompts = prompts.Split('?').Select(p => p.Trim()).ToList();
    }
    public void NumberOfItems()
    {
    }
    public void DisplayPromptWrite(int activityDuration)
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();

        Random random = new Random();
        int index = random.Next(_listingPrompts.Count);
        Console.WriteLine($"--- {_listingPrompts[index]}? ---");
        Console.WriteLine();
        
        for (int i = 5; i > 0; i--)
        {
            int currentLeft = Console.CursorLeft;
            int currentTop = Console.CursorTop;
            string message = $"You may begin in: {i}";
            Console.WriteLine(message);
            Thread.Sleep(1000);
            Console.SetCursorPosition(currentLeft, currentTop);
            Console.Write(new string(' ', message.Length));
            Console.SetCursorPosition(currentLeft, currentTop);
        }    
        Console.WriteLine($"You may begin in:");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(activityDuration);
        int items = 0;
        while (DateTime.Now < futureTime)
        {
            if (DateTime.Now >= futureTime)
                break;
            items += 1;
            Console.Write(">");
            Console.ReadLine();
        }
        Console.WriteLine($"You listed {items} items!");
    }
}