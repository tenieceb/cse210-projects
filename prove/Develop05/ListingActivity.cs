using System.Runtime.Versioning;

public class ListingActivity : Activities
{            
    List<string> _prompts;

    int _inputCount;


    public ListingActivity() : base()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _inputCount = 0;
        _durationNeeded = true;
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        // Set other values here that are unique to the Listing Activity

    }


    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("Get Ready...");
        ShowSpinner(3);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.Write("You may begin in: ");ShowCountdown(5);
        Console.WriteLine(); 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime now = DateTime.Now;
        List<string> userList = new List<string>();

        do
        {
            if (now < endTime)
            {
                GetInputListFromUser(userList);
                now = DateTime.Now;
            }
        }while (now < endTime);

        _inputCount = userList.Count();
        Console.WriteLine($"You listed {_inputCount} items!");
        DisplayEndMessage();
    }
    public string GetRandomPrompt()
    {
        Random _randomPrompt = new Random();
        int index = _randomPrompt.Next(_prompts.Count);
        return _prompts[index];

    }
    public List<string> GetInputListFromUser(List<string> userList)
    {

        Console.Write("> ");
        string userInput = Console.ReadLine();
        if (userInput != "")
        {
            userList.Add(userInput);
        }

        return userList;

    }
}