using System;
using System.IO;
using System.IO.Enumeration;



public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    static DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();
    Prompt randomPrompt = new Prompt();

    public Journal()
    {
    }
    
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        newEntry._date = dateText;
        newEntry._promptText = randomPrompt.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);
        Console.Write(">");
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry);
    }

    public void DisplayEntry()
    {
        foreach (Entry entry in _entries)
        {
           entry.GetEntry();

        }

    }

    public void SaveFile ()
    {
        Console.WriteLine("What filename do you want to save the journal to? ");
        string fileName = Console.ReadLine()+".csv";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                string saveEntrydetails = $"{entry._date},{entry._promptText},{entry._entryText}";
                outputFile.WriteLine(saveEntrydetails);
            }
        }

    }

    public void LoadFile()
    {
        Console.WriteLine("What filename do you want to load the journal from? ");
        string fileName = Console.ReadLine()+".csv";        
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
            
        }

    }


}