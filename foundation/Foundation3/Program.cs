using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>();

        Running r = new Running("10/20/2024", 30, 4.8);
        StationaryBike sb = new StationaryBike("08/01/24", 45, 15);
        SwimmingLaps sl = new SwimmingLaps("09/01/24", 60, 50);

        activities.Add(r);
        activities.Add(sb);
        activities.Add(sl);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}