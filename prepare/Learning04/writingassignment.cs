class Writing : Assignment
{
    private string _title;
    public Writing(string title, string studentName, string topic) : base(studentName, topic)
    { 
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_title}";
    }
}