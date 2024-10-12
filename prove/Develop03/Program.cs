using System;
using System.Net.Quic;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Welcome to the Scripture Memorization Tool!");
        string book = "Proverbs";
        int chapter = 3;
        int startVerse = 5;
        int endVerse = 6;
        string text = "5 Trust in the Lord with all thine heart; and lean not unto thine own understanding.6 In all thy ways acknowledge him, and he shall direct thy paths.";
        Reference reference1 = new Reference(book,chapter,startVerse,endVerse);
       
       

        Scripture scripture1 = new Scripture(reference1, text);

        Console.WriteLine("Instructions: Press Enter Key to remove words from the scripture a little at a time. Type QUIT to quit.");

        scripture1.IsCompletelyHidden();
        string scriptureText = scripture1.GetDisplayText();
        Console.WriteLine(scriptureText);
        string userinput = Console.ReadLine();
        Console.Clear();

        while (scripture1.IsCompletelyHidden() is false && userinput != "QUIT")
        {
            Console.WriteLine("Instructions: Press Enter Key to remove words from the scripture a little at a time. Type QUIT to quit.");
            scripture1.HideRandomWords(1);
            string hiddenScriptureText = scripture1.GetDisplayText();
            Console.WriteLine(hiddenScriptureText);
            userinput = Console.ReadLine();
            Console.Clear();
            scripture1.IsCompletelyHidden();

        } 
        
    }
}
