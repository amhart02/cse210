using System.Runtime.CompilerServices;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new Reference(name, chapter, verse);
        //assisted by ChatGPT
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(name, chapter, startVerse, endVerse);
        //assisted by ChatGPT
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideSomeWords()
    {
        Random random = new Random();
        //assisted by chatGPT
        int wordsToHide = Math.Min(3, _words.Count(word => !word.IsHidden()));

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            if (_words[index].IsHidden() == false)
            {
                _words[index].SetIsHidden(true);
            }
            else
            {
                i--;
            }
    }
    }
        public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
    public void ShowScripture()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetScriptureReferenceString());
        Console.WriteLine(string.Join(" ", _words.Select(word => word.GetWord())));
    }
}
