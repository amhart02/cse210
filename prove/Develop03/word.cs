using System.Runtime.CompilerServices;

public class Word
{
    private string _word; 
    private bool _hidden;
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public void SetIsHidden(bool hidden)
    {
        _hidden = hidden;
    }
    public string GetWord()
    {
        if (_hidden == true)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }
}