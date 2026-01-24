using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("\nJournal Entries");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}~|~{entry._mood}");
            }
        }
        Console.WriteLine("Saved to file successfully.");
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        try
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");

                if (parts.Length == 4)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string entryText = parts[2];
                    string mood = parts[3];

                    Entry loadedEntry = new Entry(date, prompt, entryText, mood);
                    _entries.Add(loadedEntry);
                }
            }
            Console.WriteLine("Loaded from file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}