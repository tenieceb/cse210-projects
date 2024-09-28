using System;

public class Entry
{
  string _date = "";
  string _promptText = "";
  
  string _entryText = "";

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}