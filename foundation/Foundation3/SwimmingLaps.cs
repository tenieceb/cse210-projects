public class SwimmingLaps : Activity
{
    double _numberOfLaps;

    public SwimmingLaps(string date, int durationMinutes, double numberOfLaps):base(date, durationMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double distanceInKm = _numberOfLaps * 50 / 1000;
        return distanceInKm;
    }
    
}