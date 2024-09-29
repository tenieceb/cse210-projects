using System;

public class Entry
{
  public string _promptText;
  public string _date;
  public string _entryText;

  public Entry()
  {
  }

    public void GetEntry()
    {
        Console.WriteLine("");
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine("");

    }
}