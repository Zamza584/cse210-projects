public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word wrd = new Word(word);
            _words.Add(wrd);
        }
    }

    public string GetDisplayText()
    {
        List<string> words = new List<string>();

        foreach (Word word in _words)
        {
            string w = word.GetDisplayText();
            words.Add(w);
        }

        string result = String.Join(" ", words);
        return result;
    }

}