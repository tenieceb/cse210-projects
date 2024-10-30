public abstract class Activity
{
    protected string _date;
    protected int _durationMinutes;


    public Activity (string date, int durationMinutes)
    {

        _date = date;

        _durationMinutes = durationMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual void GetSummary()
    {
        
        Console.WriteLine( $"- {_date} {GetType()} ({_durationMinutes}min) | Distance: {GetDistance()} miles | Speed: {GetSpeed()} kph | Pace: {GetPace()} min per km");
    }
}