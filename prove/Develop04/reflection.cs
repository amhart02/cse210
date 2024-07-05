using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

class Reflection : Activity 
{
    private List<string> _reflectionPrompts = new List<string> ();
    private List<string> _reflectionQuestions = new List<string> ();
    public Reflection(string prompts, string questions, string startMessage, string description, string finishMessage, int duration, string activityType) : base(startMessage, description, finishMessage, duration, activityType)
    {
        _reflectionPrompts = prompts.Split('.').Select(p => p.Trim()).ToList();
        _reflectionQuestions = questions.Split('?').Select(q => q.Trim()).ToList();
    }
    public void DisplayQuestions(int activityDuration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(activityDuration);
        while (DateTime.Now < futureTime)
        {
            foreach (string question in _reflectionQuestions)
            {
                if (DateTime.Now >= futureTime)
                break;
                Console.Write($"> {question}? "); 
                Spinner();
                Console.WriteLine();
            }
        }
    }
    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Random random = new Random();
        int index = random.Next(_reflectionPrompts.Count);
        Console.WriteLine($"--- {_reflectionPrompts[index]}. ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press a key to continue.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        
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
        Console.Clear();
    }
}