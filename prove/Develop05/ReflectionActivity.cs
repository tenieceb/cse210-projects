public class ReflectionActivity : Activities
{
    List<string> _prompts;
    List<string> _promptQuestion;

    public ReflectionActivity() : base ()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resisilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _promptQuestion = new List<string>()
        {
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "Why was this experience meaningful to you?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        // Set other values here that are unique to the Reflecting Activity
    }

    public void Run()
    {
        DisplayStartMessage();

        DateTime now;

        
        Console.WriteLine("Consider the following prompt:");
        GetRandomPrompt();
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string userEnter = Console.ReadLine();
        Console.Write("You may begin in:"); ShowCountdown(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        do
        {
            GetRandomQuestion();
            DisplayQuestions();
            now = DateTime.Now;
        }while (now < endTime);

        DisplayEndMessage();
        
    
    }
    public string GetRandomPrompt()
    {
        Random _randomPrompt = new Random();
        int index = _randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    { 
        Random _randomQuestion = new Random();
        int index = _randomQuestion.Next(_promptQuestion.Count);
        return _promptQuestion[index];
    }
    public void DisplayPrompt()
    {
        string _randomPrompt = GetRandomPrompt();
        Console.WriteLine($"---{_randomPrompt}---");

    }
    public void DisplayQuestions()
    { 
        string _randomQuestion = GetRandomQuestion();
        Console.Write($"\n> {_randomQuestion}  ");
        ShowSpinner(5);

    }
}