using System.Diagnostics;

public class Word
{
    private string _text;

    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        string underscore = "_";
        for (int i = 0; i < _text.Length - 1; i++) // used ai to get the length info 
        {
            underscore += "_";
        }

        _text = underscore;

    }
    public void Show()
    {
        Console.WriteLine(_text);
    }
    public bool IsHidden()
    {
        if (_isHidden)
        {
            return true;
        }

        return false;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}