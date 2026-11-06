using System;
using System.Collections.Generic;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Shows this entry on the screen
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }

    // Turns this entry into one CSV line (quotes and commas are handled)
    public string ToCsvLine()
    {
        return $"{Escape(_date)},{Escape(_promptText)},{Escape(_entryText)}";
    }

    // Builds an Entry from one CSV line. Returns null if the line is invalid.
    public static Entry FromCsvLine(string line)
    {
        List<string> fields = new List<string>();
        string current = "";
        bool inQuotes = false;

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];

            if (inQuotes)
            {
                if (c == '"')
                {
                    // Two quotes in a row means one real quote character
                    if (i + 1 < line.Length && line[i + 1] == '"')
                    {
                        current += '"';
                        i++;
                    }
                    else
                    {
                        inQuotes = false;
                    }
                }
                else
                {
                    current += c;
                }
            }
            else
            {
                if (c == '"')
                {
                    inQuotes = true;
                }
                else if (c == ',')
                {
                    fields.Add(current);
                    current = "";
                }
                else
                {
                    current += c;
                }
            }
        }
        fields.Add(current);

        if (fields.Count < 3)
        {
            return null;
        }

        return new Entry(fields[0], fields[1], fields[2]);
    }

    private static string Escape(string value)
    {
        return "\"" + value.Replace("\"", "\"\"") + "\"";
    }
}
