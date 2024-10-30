 public class Running : Activity
{            
    double _distanceInKm;
    public Running(string date, int durationMinutes, double distanceInKm):base(date, durationMinutes)
    {
        _distanceInKm = distanceInKm;
    }

    public override double GetDistance()
    {
        return _distanceInKm;
    }
    public override double GetSpeed()
    {
        double speed = 60/GetPace();
        return speed;
    }
    public override double GetPace()
    {
        double pace = _durationMinutes / _distanceInKm;
        return pace;
    }
}