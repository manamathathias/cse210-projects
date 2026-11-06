using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToCsvLine());
            }
        }
        Console.WriteLine($"Journal saved to {filename}.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("That file was not found.");
            return;
        }

        // Loading replaces whatever is currently in the journal
        _entries.Clear();

        foreach (string line in File.ReadAllLines(filename))
        {
            Entry entry = Entry.FromCsvLine(line);
            if (entry != null)
            {
                _entries.Add(entry);
            }
        }
        Console.WriteLine($"Journal loaded from {filename}.");
    }
}
