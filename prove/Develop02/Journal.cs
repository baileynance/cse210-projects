using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    List<string> _entries = new List<string>();

    public void AddEntry(Entries entries)
    {
        _entries.Add(entries.CreateEntry());
    }
    public void DisplayEntries()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveFile(string fileName)
    {
        using (StreamWriter file = new StreamWriter(fileName))
        {
            foreach (string entry in _entries)
            {
                file.WriteLine(entry);
            }
        }
    }

    public void LoadFile(string fileName)
    {
        string[] file = System.IO.File.ReadAllLines(fileName);

        _entries.Clear();

        foreach (string line in file)
        {
            _entries.Add(line);
        }
    }

    public void ClearFile()
    {
        _entries.Clear();
    }
}
