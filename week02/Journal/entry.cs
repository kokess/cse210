using System;

class Entry
{
    private string _date;
    private string _prompt;
    private string _response;
    private string _mood;

    public Entry(string date, string prompt, string response, string mood)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Mood: {_mood}/5");
    }

    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_response}|{_mood}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("|");
        return new Entry(parts[0], parts[1], parts[2], parts[3]);
    }
}
