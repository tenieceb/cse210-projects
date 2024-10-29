 public class StationaryBike : Activity
{
    double _speed;
    public StationaryBike(DateTime date, int durationMinutes, double speed):base(date, durationMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distanceInKm = _durationMinutes / GetPace();
        return distanceInKm;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }
}