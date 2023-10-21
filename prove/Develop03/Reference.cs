using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference(string book)
    {
        _book = book;
        _chapter = "";
        _verse = "";
        _endVerse = "";
    }

    public Reference(string book, string chapter)
        {
        _book = book;
        _chapter = chapter;
        _verse = "";
        _endVerse = "";
    }

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = "";
    }
    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        return $"{_book} {_chapter}";
    }

    public string GetVerse()
    {
        if (_endVerse == "")
        {
            return $"{_verse} \n{_endVerse}";
        }
        else 
        {
            return _verse;
        }
    }
}