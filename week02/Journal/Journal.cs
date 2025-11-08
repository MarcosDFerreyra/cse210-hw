using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        PromptGenerator prompt1 = new PromptGenerator();
        string randomPrompt = prompt1.GetRandomPrompt();

        Console.WriteLine(randomPrompt);
        Console.Write("Write here: ");
        string entrytext = Console.ReadLine();
        Console.Write("Date: ");
        string date = Console.ReadLine();


        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._entryText = entrytext;
        newEntry._promptText = randomPrompt;
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile()
    {
        Console.Write("Name of the file: ");
        string filename = Console.ReadLine();
        using (StreamWriter newFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                newFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
    }
    public void loadFromFile()
    {
        Console.Write("Name of the file: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            _entries.Add(newEntry);

        }
    }
}