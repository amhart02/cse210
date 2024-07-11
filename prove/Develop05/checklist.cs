class Checklist : Goal 
{
    private int _occurences;
    private int _bonus;

    public Checklist(string name, string description, bool complete, int points, int occurences, int bonus) : base(name, description, complete, points)
    {
        _occurences = occurences;
        _bonus = bonus;
    }
}