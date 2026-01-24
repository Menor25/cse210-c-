using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    public Entry(string date, string prompt, string entry, string mood)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entry;
        _mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Mood: {_mood}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
    }
}