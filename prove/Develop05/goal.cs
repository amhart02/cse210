using System.Diagnostics.Contracts;

class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private string _goalType;
    public Goal(string name, string description, int points, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalType = goalType;
    }
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[] {_name} ({_description})");
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public string GetGoalType()
    {
        return _goalType;
    }
    public override string ToString()
    {
        return $"{_goalType},{_name},{_description},{_points}";
    }
    public virtual int RecordEvent()
    {
        return GetPoints();
    }
    public virtual void CongradulatePoints(Goal goal)
    {
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points!");
    }
}
