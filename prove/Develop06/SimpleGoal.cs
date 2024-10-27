public class SimpleGoal : Goal
{           
    bool _isComplete = false ;
    public SimpleGoal(string goalName, string goalDescription, int goalPoints, bool isComplete): base(goalName, goalDescription, goalPoints)
    {
        _isComplete = isComplete;


    }

    public override void RecordEvent() 
    {
        _isComplete = true;

        Console.WriteLine($"Congratulations! You have earned {_goalPoints} points!");
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public override string GetStringRepresentation()
    {
        // string completed;
        // if (IsComplete())
        // {
        //     completed = "true";
        // }
        // else
        // {
        //     completed = "false";
        // }
        
        return $"{IsComplete()}|Simple Goal|{_goalName}|{_goalDescription}|{_goalPoints} ";

    }
}