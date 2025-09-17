public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry myEntry)
    {
        _entries.Add(myEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] entries = line.Split("|");
            entry._date = entries[0];
            entry._promptText = entries[1];
            entry._entryText = entries[2];
            _entries.Add(entry);
        }
    }

}