using System;
using System.Collections.Generic;


public class Prompt
{
    

    public Prompt()
    {}
    public List<string> _prompts = new List<string>()
    {
        "How was the weather today?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Where did I go today? What did I do there?",
        "What was the hardest thing about today?",
        "What made me laugh today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }
    
}
        