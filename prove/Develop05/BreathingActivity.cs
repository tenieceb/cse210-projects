public class BreathingActivity : Activities
{
    public BreathingActivity() : base()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n This activity is best done in increments of 20 seconds.";
        _durationNeeded = true;
    }


    public void Run()
    {
        DisplayStartMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime now;

        Console.WriteLine("Get ready. . .");
        ShowSpinner(2);
        
        do
        {
            now = DateTime.Now;
            int seconds = 4;
            if (now < endTime)
            {
                Console.Write($"\nBreathe in...");ShowCountdown(seconds);
                Console.WriteLine();
                now = DateTime.Now;
            }
            if (now < endTime)
            {
                Console.Write($"Hold...");ShowCountdown(seconds);
                Console.WriteLine();
                now = DateTime.Now;
            }
            if (now < endTime)
            {
                Console.Write($"Breathe out..."); ShowCountdown(seconds);
                Console.WriteLine();
                now = DateTime.Now;
            }

            if (now < endTime)
            { 
                Console.Write($"Hold...");ShowCountdown(seconds);
                Console.WriteLine();
                now = DateTime.Now;
            }

        } while (now < endTime);

        
        DisplayEndMessage();
    
    }
}