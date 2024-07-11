class Goal 
{
    private string _name;
    private string _description;
    private bool _complete;
    private int _points;
    public Goal(string name, string description, bool complete, int points)
    {
        _name = name;
        _description = description;
        _complete = complete;
        _points = points;
    }
}