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
}