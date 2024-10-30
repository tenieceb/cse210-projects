public abstract class Activity
{
    protected string _date;
    protected int _durationMinutes;


    public Activity (string date, int durationMinutes)
    {

        _date = date;

        _durationMinutes = durationMinutes;
    }

    public virtual double GetDistance()
    {
        double distanceInKm = _durationMinutes / GetPace();
        return distanceInKm;
    }
    public virtual double GetSpeed()
    {
        double speed = GetDistance()/_durationMinutes * 60;
        return speed;
    }
    public virtual double GetPace()
    {
        double pace = _durationMinutes/ GetDistance();
        return pace;
    }
    public void GetSummary()
    {
        Console.WriteLine( $"- {_date} {GetType()} ({_durationMinutes}min) | Distance: {GetDistance()} miles | Speed: {GetSpeed()} kph | Pace: {GetPace()} min per km");
    }
}