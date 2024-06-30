using System.Runtime.InteropServices;

public class Reference 
{
    private string _bookName;
    private int _chapter;
    private int[] _verse;
    public Reference(string bookName, int chapter, int verse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = new int[] {verse};
    }
    public Reference(string bookName, int chapter, int startVerse, int endVerse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = new int[] {startVerse, endVerse};
    }
    public string GetScriptureReferenceString() 
    {
        if (_verse.Length == 1)
        {
            return $"{_bookName} {_chapter}:{_verse[0]}";
        }
        else 
        {
            return $"{_bookName} {_chapter}:{_verse[0]}-{_verse[1]}";
        }
    }
}