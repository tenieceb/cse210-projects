using System;
class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference();
        

        Console.WriteLine("Welcome to the Scripture Memorization Tool!");

        Console.WriteLine("Please enter the Book of the scripture you are memorizing today (ex. John): ");
        string book = Console.ReadLine();

        Console.WriteLine("Please enter the Chapter number (ex. 3): ");
        int chapter = int.Parse(Console.ReadLine());

        Console.WriteLine("Will you be memorizing more than one verse? (YES or NO) ");
        string verseQuestion = Console.ReadLine();

        if (verseQuestion == "YES")
        {
            Console.WriteLine("Please enter the Starting Verse Number (ex. If you are memorizing Matthew 5:14 - 16 you will input 14 here): ");
            int startVerse = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Ending Verse Number (ex. Using the previous example the ending verse number is 16): ");
            int endVerse = int.Parse(Console.ReadLine());
            reference1 = new Reference(book, chapter, startVerse, endVerse);

        }
        else if (verseQuestion == "NO")
        {
            Console.WriteLine("What is the Verse Number you will be memorizing? (ex. 15) ");
            int verse = int.Parse(Console.ReadLine());
            reference1 = new Reference(book, chapter, verse);
        }

        else
        {
            Console.WriteLine("Invalid Response.");
        }


        Console.WriteLine("Please enter the Text of the verse: ");
        string text = Console.ReadLine();

        Scripture scripture1 = new Scripture(reference1, text);

        Console.WriteLine("Instructions: Press Enter Key to remove words from the scripture a little at a time.");

        scripture1.IsCompletelyHidden();
        string scriptureText = scripture1.GetDisplayText();
        Console.WriteLine(scriptureText);
        Console.ReadLine();
        Console.Clear();

        do
        {

            scripture1.HideRandomWords(3);
            string youAreABooger = scripture1.GetDisplayText();
            Console.WriteLine(youAreABooger);
            Console.ReadLine();
            Console.Clear();
            scripture1.IsCompletelyHidden();

        } while (scripture1.IsCompletelyHidden() is false);
    }
}
