public class Grounding :Activities
{  
    public Grounding()
    {
        _name = "Grounding";
        _description = "This activity will help you feel grounded by making lists of things you see, touch, hear, smell, and taste.";
        _durationNeeded = false;
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("Get ready...");
        ShowCountdown(5);
        Console.WriteLine("\nList 5 things you can SEE: ");
        DisplayListText(5);
        Console.WriteLine("\nList 4 things you can TOUCH: ");
        DisplayListText(4);
        Console.WriteLine("\nList 3 things you can HEAR: ");
        DisplayListText(3);
        Console.WriteLine("\nList 2 things you can SMELL: ");
        DisplayListText(2);
        Console.WriteLine("\nList 1 thing you can TASTE: ");
        DisplayListText(1);

        DisplayEndMessage();

    }

    public void DisplayListText(int items)
    {
        List<string> userList= new List<string>();
        int i = items;
        while (userList.Count() <= items && i != 0)
        {
            Console.WriteLine($"{i} ");
            string userInput = Console.ReadLine();
            userList.Add(userInput);
            userList.Count();
            i -= 1;
        }
    }



}
