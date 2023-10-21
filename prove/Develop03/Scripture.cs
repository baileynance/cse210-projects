using System;
using System.Diagnostics.Metrics;

public class Scripture
{
    private string _reference;
    private string _scripture;
    private string _newScript;

    public Scripture(string reference)
    {
        _reference = reference;
        _scripture = "";
        _newScript = "";
    }
    public Scripture(string reference, string scripture)
    {
        _reference = reference;
        _scripture = scripture;
        _newScript = scripture;
    }

    public void HideWords()
    {
        string[] split = _newScript.Split(" ");
        string newScript = "";

        int runCounter = 0;

        foreach (string word in split)
        {
            Word w = new Word(word);

            var random = new Random();
            var randomBool = random.Next(2) == 1;

            if (w.IsNotHidden() && runCounter < 3)
            {
                w.Hide();

                runCounter++;
            }

            string adjustedWord = w.GetWord();
            newScript = newScript + adjustedWord + " ";

            _newScript = newScript;
        }
    }

    public bool IsHidden()
    {
        string[] split = _scripture.Split(" ");
        string[] newSplit = _newScript.Split(" ");

        int hiddenCounter = 1;
        
        foreach (string word in newSplit)
        {  
            Word w = new Word(word);

            if (!w.IsNotHidden())
            {
                hiddenCounter++;
            }
        }

        if (hiddenCounter == split.Length)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public string GetScripture()
    {
        return $"{_reference} {_newScript}";
    }

    public string GetHiddenScripture()
    {
        return "hello";
    }
}