using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

class Checklist : Goal
{
    private bool _complete;

    private int _occurences;
    private int _occurencesCompleted;
    private int _bonus;

    public Checklist(string name, string description, int points, string goalType, int occurences, int bonus, int occurencesCompleted, bool complete) : base(name, description, points, goalType)
    {
        _occurences = occurences;
        _bonus = bonus;
        _complete = complete;
        _occurencesCompleted = occurencesCompleted;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{GetCompletePlaceholder()}] {GetName()} ({GetDescription()}) -- Currently completed: {_occurencesCompleted}/{_occurences}");
    }
    public override string ToString()
    {
        return $"{GetGoalType()},{GetName()},{GetDescription()},{GetPoints()},{GetComplete()},{_bonus},{_occurences},{_occurencesCompleted}";
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
        _occurencesCompleted++;
        if (_occurencesCompleted >= _occurences)
        {
            _complete = true;
            return GetPoints() + _bonus;
        }
        return GetPoints();
    }
    public override void CongradulatePoints(Goal goal)
    {
        if (_occurencesCompleted >= _occurences)
        {
            Console.WriteLine();
            Console.WriteLine($"Congratulations! You have earned {goal.GetPoints() + _bonus} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points!");
        }
    }
}