using System;
// Exceed requirements by creating the save file to be a csv that is sepratated out.
class Program
{
    static void Main(string[] args)
    {
        string journalOpen;
        Journal newSession = new Journal();
        
        do
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Welcome to your journal");
            Console.WriteLine("");

            Console.WriteLine("Please select from the following choices:");
            Console.WriteLine("");


            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?  ");
            journalOpen = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");


            if (journalOpen == "1")
            {
                newSession.AddEntry();
                Console.WriteLine("");
            }
            else if (journalOpen == "2")
            { 
                newSession.DisplayEntry();
                Console.WriteLine("");


            }
            else if (journalOpen == "3")
            {
                newSession.SaveFile();
               Console.WriteLine("");
            }

            else if (journalOpen == "4")
            {
                newSession.LoadFile();
                Console.WriteLine("");
            }

        }while (journalOpen != "5");

    }
}