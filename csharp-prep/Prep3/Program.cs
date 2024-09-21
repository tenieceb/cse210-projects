using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        string replay;
       do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int guess;
            int tries = 0;
            
            do
            {
                Console.Write("What is your guess? ");
                string input2 = Console.ReadLine();
                guess = int.Parse(input2);
                if (guess > magicNumber )
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber )
                {
                    Console.WriteLine("Higher");
                }
                tries += 1;
            }while (guess != magicNumber);

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {tries} guess(es) to beat the game!");
            }

            Console.Write("Would you like to play again? ");
            replay = Console.ReadLine();
        } while(replay == "yes");
    }    
}