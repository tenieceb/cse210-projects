public class EternalGoal : Goal
{            
    static DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();

    bool _isComplete = false; 
    public EternalGoal(string goalName, string goalDescription, int goalPoints, bool isComplete) :base(goalName,goalDescription,goalPoints)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        DateTime now = DateTime.Now;
        if(dateText == now.ToShortDateString())
        {
            _isComplete = true;
        }
        Console.WriteLine($"Congratulations! You have earned {_goalPoints}!");
    }

    public override bool IsComplete()
    {
        DateTime now = DateTime.Now;
        if (_isComplete == true && dateText == now.ToShortDateString())
        {
            return true;
        }
        else return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{IsComplete()}|Eternal Goal|{_goalName}|{_goalDescription}|{_goalPoints} ";
    }
    
}    