using System;

public class Word
{
    private string _originalWord;
    private string _word;
    private bool _isHidden;

    public Word(string word)
    { 
        _word = word;
        _originalWord = word;
        _isHidden = false;
    }

    public void Hide()
    {
        if (!_isHidden)
        {
            _word = new string('_', _word.Length);
        }
    }

    public void Show()
    {
        _word = _originalWord;
    }

    public bool IsNotHidden()
    {
        string underscore = "_";

        if (_word.Contains(underscore))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public string GetWord()
    {
        return _word;
    }
}