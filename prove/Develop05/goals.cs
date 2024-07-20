using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

class Goals
{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    private int _numberGoalsCompleted;
    public Goals()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
        _numberGoalsCompleted = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public int GetScore()
    {
        return _score;
    }
    public int GetLevel()
    {
        return _level;
    }
    public void LevelUp()
    {
        _level += 1;
    }
    public int GetNumberGoalsCompleted()
    {
        return _numberGoalsCompleted;
    }
    public void ChangeNumberGoalsCompleted()
    {
        _numberGoalsCompleted += 1;
    }
    public void DisplayGoals()
    {
        int goalNumber = 1;
        Console.WriteLine();
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals)
        {
            Console.Write($"{goalNumber}.");
            goal.DisplayGoal();
            goalNumber += 1;
        }
    }
    public void SaveToFile()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                string stringGoal = goal.ToString();
                outputFile.WriteLine(stringGoal);
            }
        }
    }
    public static List<Goal> ReadFromFile()
    {
        List<Goal> goals = new List<Goal>();
        Console.Write("What is the filename for the goal file? ");

        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length < 4)
            {
                continue;
            }

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            Goal goal;
            if (goalType == "SimpleGoal")
            {
                bool complete = bool.Parse(parts[4]);
                goal = new Simple(name, description, points, goalType, complete);
            }
            else if (goalType == "EternalGoal")
            {
                goal = new Eternal(name, description, points, goalType);
            }
            else if (goalType == "ChecklistGoal")
            {
                bool complete = bool.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int occurences = int.Parse(parts[6]);
                int occurencesCompleted = int.Parse(parts[7]);
                goal = new Checklist(name, description, points, goalType, occurences, bonus, occurencesCompleted, complete);
            }
            else
            {
                continue;
            }
            goals.Add(goal);
        }
        return goals;
    }
    public void LoadGoals(List<Goal> goals)
    {
        _goals = goals;
    }
    public Goal GetGoalByIndex(int index)
    {
        return _goals[index];
    }
    public void AddScore(int points)
    {
        _score += points;
    }
}
