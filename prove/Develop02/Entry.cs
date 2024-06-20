using System;

public class Entry
{
    private string _date;
    private string _timestamp;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string timestamp, string promptText, string entryText)
    {
        _date = date;
        _timestamp = timestamp;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_timestamp}"); 
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }

    public override string ToString()
    {
        return $"{_date}|{_timestamp}|{_promptText}|{_entryText}";
    }

    public static Entry FromString(string entryString)
    {
        var parts = entryString.Split('|');
        return new Entry(parts[0], parts[1], parts[2], parts[3]);
    }
}
