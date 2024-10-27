public class ChecklistGoal : Goal
{    
    int _totalCompleted;
    int _target;
    int _bonus;
    public ChecklistGoal(string goalName, string goalDescription, int goalPoints, int target, int bonus, int totalCompleted ): base(goalName,goalDescription, goalPoints)
    {
        _target = target;
        _bonus = bonus;
        _totalCompleted = totalCompleted;
    }
    public override void RecordEvent()
    {
        _totalCompleted += 1;
        Console.WriteLine($"Congratulations! You earned {_goalPoints} points!");
        if (_totalCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You completed your target and earned {_bonus} points! ");
        }
    }
    public override bool IsComplete()
    {
        if(_totalCompleted == _target)
        {
            return true;
        }
        else return false;

    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] Goal: {_goalName} Description: {_goalDescription} -- Completed: {_totalCompleted}/{_target}";
        }
        else 
            return $"[ ] Goal: {_goalName} Description: {_goalDescription} -- Completed: {_totalCompleted}/{_target}";


    }
    public override string GetStringRepresentation()
    {
        
        return $"{IsComplete()}|Checklist Goal|{_goalName}|{_goalDescription}|{_goalPoints}|{_bonus}|{_totalCompleted}|{_target} ";

    }

    public override int SetGoalPoints()
    {
        if(IsComplete())
        {
            return _bonus + _goalPoints;
        }
        else return _goalPoints;
    }
}   
