public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }
    public Fraction(int number)
    {
        _topNumber = number;
        _bottomNumber = 1;
    }
    public Fraction(int number, int number2)
    {
        _topNumber = number;
        _bottomNumber = number2;
    }
    public string GetFractionString()
    {
        string fractionString = $"{_topNumber}/{_bottomNumber}";
        return fractionString;
    }
    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }
}