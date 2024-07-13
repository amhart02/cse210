class Eternal : Goal
{
    public Eternal(string name, string description, int points, string goalType) : base(name, description, points, goalType)
    {
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {GetName()} ({GetDescription()})");
    }
    public override string ToString()
    {
        return $"{GetGoalType()},{GetName()},{GetDescription()},{GetPoints()}";
    }
    public override int RecordEvent()
    {
        return GetPoints();
    }
    public override void CongradulatePoints(Goal goal)
    {
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points!");
    }
}