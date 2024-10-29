public class SwimmingLaps : Activity
{
    double _numberOfLaps;

    public SwimmingLaps(DateTime date, int durationMinutes, double numberOfLaps):base(date, durationMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double distanceInKm = _numberOfLaps * 5 / 1000;
        return distanceInKm;
    }
    public override double GetSpeed()
    {
        double _ = GetDistance()/_durationMinutes;
        double speed = _ * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;

    }
}