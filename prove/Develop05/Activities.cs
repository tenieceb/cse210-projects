using System.Reflection.Metadata;

public class Activities
{
    protected string _name;
    protected string _description;
    protected int _duration; 
    protected bool _durationNeeded;


    public Activities()
    {}


    public void DisplayStartMessage()
    {
        DisplayStartProgramText();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        if (_durationNeeded)
        {
            Console.WriteLine("\nHow long, in seconds, would you like your session? ");
            string userDuration = Console.ReadLine();
            _duration = int.Parse(userDuration);
        }
        else if(_durationNeeded == false)
        {
            Console.WriteLine("Due to the nature of this activity, it will end when you've completed the activity, press ENTER to continue");
            Console.ReadLine();
        }
        Console.Clear();
    }
    public void DisplayEndMessage()
    {

        Console.WriteLine("\n\nWell done!!\n");
        if (_durationNeeded)
            Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        else if (_durationNeeded == false)
            Console.WriteLine($"You have completed the {_name} Activity.");
            
        Console.WriteLine("Press ENTER when you are ready to return to the main menu.");
        Console.ReadLine();
        Console.WriteLine("Returning to main menu...");
        ShowSpinner(2);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>()
        {
            "|", "/", "-","\\","|","/","-","\\","|"
        };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        DateTime now;

        do
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(100);
                Console.Write("\b \b");
            }
            now = DateTime.Now;

        }while  ( now < endTime) ;        
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayStartProgramText()
    {
        Console.Write($"Loading activity {_name} ");
        ShowSpinner(1);
        Console.Clear();
    }
}