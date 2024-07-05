class Breathing : Activity
{
    public Breathing(string startMessage, string description, string finishMessage, int duration, string activityType) : base(startMessage, description, finishMessage, duration, activityType)
    {
    }
    public void BreatheIn(int seconds)
    {
        Console.WriteLine();
        for (int i = seconds; i > 0; i--)
        {
            int currentLeft = Console.CursorLeft;
            int currentTop = Console.CursorTop;
            string message = $"Breathe in...{i}";
            Console.WriteLine(message);
            Thread.Sleep(1000);
            Console.SetCursorPosition(currentLeft, currentTop);
            Console.Write(new string(' ', message.Length));
            Console.SetCursorPosition(currentLeft, currentTop);
        }    
        Console.WriteLine($"Breathe in...");
    }
    public void BreatheOut(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            int currentLeft = Console.CursorLeft;
            int currentTop = Console.CursorTop;
            string message = $"Now breathe out...{i}";
            Console.WriteLine(message);
            Thread.Sleep(1000);
            Console.SetCursorPosition(currentLeft, currentTop);
            Console.Write(new string(' ', message.Length));
            Console.SetCursorPosition(currentLeft, currentTop);
        }    
        Console.WriteLine($"Now breathe out...");
    }
}
