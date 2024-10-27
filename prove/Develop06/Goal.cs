public abstract class Goal
{
    protected int _goalPoints;
    protected string _goalName;
    protected string _goalDescription;

    public Goal (string goalName, string goalDescription, int goalPoints)
    {
        _goalPoints = goalPoints;
        _goalName = goalName;
        _goalDescription = goalDescription;
    }

    
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    // -This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.

    public virtual int SetGoalPoints()
    {
        return _goalPoints;
    }
    public virtual string GetDetailsString()
    // - This method should return the details of a goal that could be shown in a list.
    //  It should include the checkbox, the short name, and description. 
    // Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.
    {
        if (IsComplete())
        {
            return $"[X] Goal: {_goalName} Description: {_goalDescription}";
        }
        else 
            return $"[ ] Goal: {_goalName} Description: {_goalDescription}";
    
    }


}