public class BreathingActivity : Activities
{
    public BreathingActivity() : base()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }


    public void Run()
    {
        DisplayStartMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime now;

        Console.WriteLine("Get ready. . .");
        ShowSpinner(5);
        
        do
        {
            int seconds = 4;
            Console.Write($"\nBreathe in...");ShowCountdown(seconds);
            Console.WriteLine();
            
            Console.Write($"Hold...");ShowCountdown(seconds);
            Console.WriteLine();

            Console.Write($"Breathe out..."); ShowCountdown(seconds);
            Console.WriteLine();

            Console.Write($"Hold...");ShowCountdown(seconds);
            Console.WriteLine();

            now = DateTime.Now;

        } while (now < endTime);

        
        DisplayEndMessage();
    
    }
}