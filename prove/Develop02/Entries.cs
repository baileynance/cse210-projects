using System;

public class Entries
{  
    public List<string> _entries = new List<string>();

    public void DisplayJournal()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
}