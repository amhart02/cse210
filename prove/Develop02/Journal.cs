using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry> ();

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public static void SaveToFile(Journal journal)
    {
        Console.WriteLine("Please provide a file name.");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in journal._entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._response);
                outputFile.WriteLine();
            }
        }
    }
    public static List<Entry> ReadFromFile()
    {
        List<Entry> entries = new List<Entry>();
        Console.WriteLine("Please provide a file name.");
        Console.WriteLine();
        
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        return entries;
    }
}