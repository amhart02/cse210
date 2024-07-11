abstract class Employee 
{
    private string _name;
    private double _hoursWorked;
    private double _hourlyWage;

    public Employee(string name, double hoursWorked, double hourlyWage)
    {
        _name = name;
        _hoursWorked = hoursWorked;
        _hourlyWage = hourlyWage;
    }
    public virtual double GetPay()
    {
        return _hourlyWage * _hoursWorked;
    }
    public string GetName()
    {
        return _name;
    }
    public override string ToString()
    {
        return $"name: {_name}, hours: {_hoursWorked}, wage: {_hourlyWage}";
    }
    public abstract double InsuranceCost();
}