class Fireman : Person
{
    private string _certifications;

    public Fireman(string certifications, string f, string l, int a, int w) : base(f, l, a, w)
    {
        _certifications = certifications;
    }
    public string FiremanInformation()
    {
        return $"{_certifications}, {PersonInformation()}";
    }
}