using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        // Console.WriteLine("Hello Prep5 World!");

        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // PromptUserName - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numberInput = Console.ReadLine();
            int userNumber = int.Parse(numberInput);
            return userNumber;
        }

        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
       static int SquareNumber(int userNumber)
       {
        int numberSquared = userNumber * userNumber;
        return numberSquared;
       } 

        // DisplayResult - Accepts the user's name and the squared number and displays them.
       static void DisplayResult(string userName, int numberSquared)
       {
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}.");
       }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber= PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);
        



       DisplayResult(userName, numberSquared);
    
    }
}