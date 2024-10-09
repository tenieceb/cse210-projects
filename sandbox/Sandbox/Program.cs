using System;

class Program
{
    static void Main(string[] args)
    {
        string s = "You win some. You lose some.";
        char[] separators = new char[] { ' ', '.' };

        string[] subs = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (var sub in subs)
        {
            Console.Write($" {sub}");    
        }
}}