using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string  gradePercentage = Console.ReadLine();
        int gradeNumber = int.Parse(gradePercentage);

        string letter;

        if (gradeNumber >= 90)
        {
            letter = "A";
            // Console.WriteLine($"Your letter grade is: {letter}.");

        }
        else if (gradeNumber < 90 && gradeNumber >= 80)
        {
            letter = "B";
            // Console.WriteLine($"Your letter grade is: {letter}.");

        }
        else if (gradeNumber < 80 && gradeNumber >= 70)
        {
            letter = "C";
            // Console.WriteLine($"Your letter grade is: {letter}");
        }
        else if (gradeNumber < 70 && gradeNumber >= 60)
        {
            letter = "D";
            // Console.WriteLine($"Your letter grade is: {letter}.");
        }
        else
        {
            letter = "F";
            // Console.WriteLine($"Your letter grade is: {letter}.");

        }

        Console.WriteLine($"Your letter grade is: {letter}.");
    

        if (gradeNumber >= 70)
        {
            Console.WriteLine("You passed! Congratulations! ");
        }
        else
        {
            Console.WriteLine("You didn't pass. Don't worry, You'll do better next time.");
        }
    }
}