
using System.IO;


public class Journal
{

    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {

        foreach (Entry entry in _entries)
        {
            entry.Display();

        }

    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            Console.WriteLine($"Saving {_entries.Count} entries...");
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}| ");

            }
        }
    }

    public void LoadFromFile(string file)
    {

        string[] lines = System.IO.File.ReadAllLines(file);


        foreach (string line in lines)
        {
            Entry entry = new Entry();

            string[] parts = line.Split("|");
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            AddEntry(entry);

        }
    }
}