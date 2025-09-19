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
    public void HideRandomWords(int numberToHide)
    {
        int[] rndIndexes = new int[numberToHide];

        for (int i = 0; i < numberToHide; i++)
        {
            Random random = new Random();
            int rndIndex = random.Next(_words.Count);
            rndIndexes.Append(rndIndex);
            _words[rndIndex].Hide();
        }

        // foreach (int index in rndIndexes)
        // {
        //     if (index[rndIndexes])
        // }
    }

    public string GetDisplayText()
    {

        string refText = _reference.GetReferenceText();

        List<string> words = new List<string>();

        foreach (Word word in _words)
        {
            string w = word.GetDisplayText();
            words.Add(w);
        }

        string result = refText + " " + String.Join(" ", words);
        return result;

    }
}