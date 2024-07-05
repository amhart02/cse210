class Activity
{
    private string _startMessage;
    private string _description;
    private string _finishMessage;
    private int _duration;
    private string _activityType;
    public Activity(string startMessage, string description, string finishMessage, int duration, string activityType)
    {
        _startMessage = startMessage;
        _description = description;
        _finishMessage = finishMessage;
        _duration = duration;
        _activityType = activityType;
    }
    public int GetDuration()
    {
        int activityDuration = 0; 
        Console.WriteLine("How long, in seconds, would you like for your session?");
        activityDuration = int.Parse(Console.ReadLine());
        return activityDuration;
    }
    public void DisplayDuration()
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityType} activity.");
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine(_startMessage);
    }
    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }
    public void DisplayFinishMessage()
    {
        Console.WriteLine();
        Console.WriteLine(_finishMessage);
    }
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");

    }
    public void Spinner()
    {
        for (int i = 0; i < 6; i++)
        { 
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\"); 
            Thread.Sleep(250);
            Console.Write("\b \b"); 

            Console.Write("|");  
            Thread.Sleep(250);
            Console.Write("\b \b"); 

            Console.Write("/"); 
            Thread.Sleep(250);
            Console.Write("\b \b"); 
        } 
    }
    public void SetAttribute(int duration)
    {
        _duration = duration;
    }
}