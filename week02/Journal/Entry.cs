public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _location;

    public string _mood;
    public string _energyLevel;
    public Entry()
    {
        _date = DateTime.Now.ToShortDateString();
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Location: {_location}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Energy Level: {_energyLevel}");
        Console.WriteLine();
    }

    public string GetSaveString()
    {
        return $"{_date}, {_location} - {_promptText}:{_entryText} |{_mood}| Energy Level: {_energyLevel}/ 10";
    }
}