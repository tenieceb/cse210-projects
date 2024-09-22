using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers= new List<int>();

        int inputNumber;
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            inputNumber = int.Parse(input);
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        } while (inputNumber != 0);

        int listSum = numbers.Sum();
        float listCount = numbers.Count();
        float listAverage = listSum / listCount;
        int listMax = numbers.Max();

        Console.WriteLine($"The sum is: {listSum}");
        Console.WriteLine($"The average is: {listAverage}");
        Console.WriteLine($"The largest number is: {listMax}");


    }
}