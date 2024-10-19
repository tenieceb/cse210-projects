using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfullness Program");
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start Breathing activity");
        Console.WriteLine(" 2. Start Reflection activity");
        Console.WriteLine(" 3. Start Listing activity");
        Console.WriteLine(" 4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string userChoice = Console.ReadLine();

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
        else
        {

        }

    }
}