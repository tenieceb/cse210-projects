public class Activities
{
    protected string _name;
    protected string _description;
    protected int _duration; 

    

    public Activities()
    {}


    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.WriteLine("\nHow long, in seconds, would you like your session? ");
        string userDuration = Console.ReadLine();
        _duration = int.Parse(userDuration);
        Console.Clear();
    }
    public void DisplayEndMessage()
    {

        Console.WriteLine("\n\nWell done!!\n");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        
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
                Thread.Sleep(250);
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
}