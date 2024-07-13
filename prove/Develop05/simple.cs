class Simple : Goal
{
    private bool _complete;
    public Simple(string name, string description, int points, string goalType, bool complete) : base(name, description, points, goalType)
    {
        _complete = complete;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{GetCompletePlaceholder()}] {GetName()} ({GetDescription()})");
    }
    public override string ToString()
    {
        return $"{GetGoalType()},{GetName()},{GetDescription()},{GetPoints()},{GetComplete()}";
    }
    public bool GetComplete()
    {
        return _complete;
    }
    public string GetCompletePlaceholder()
    {
        // helped by chat GPT, returns an x if true and a space if false
        return GetComplete() ? "x" : " ";
    }
    public override int RecordEvent()
    {
        _complete = true;
        return GetPoints();
    }
    public override void CongradulatePoints(Goal goal)
    {
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points!");
    }
}