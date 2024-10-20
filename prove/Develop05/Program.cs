// Exceeds requirements: Created another "Grounding Activity"
using System;
using System.Net.Quic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfullness Program");
        string userChoice;
        Activities session = new Activities();
        do
        {   
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing activity");
            Console.WriteLine(" 2. Start Reflection activity");
            Console.WriteLine(" 3. Start Listing activity");
            Console.WriteLine(" 4. Start Grounding activity");
            Console.WriteLine(" 5. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            userChoice = Console.ReadLine();


            if(userChoice == "1")
            {
                BreathingActivity breath = new BreathingActivity();
                breath.Run();
            }
            else if (userChoice == "2")
            {
                ReflectionActivity reflect = new ReflectionActivity();
                reflect.Run();
            }
            else if (userChoice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (userChoice == "4")
            {
                Grounding grounding = new Grounding();
                grounding.Run();
            }
            else if (userChoice != "5") 
            {
                Console.WriteLine("That is an invalid choice.");
                Thread.Sleep(2000);
                Console.Clear();
            }


            
        }while (userChoice != "5");

    }
}