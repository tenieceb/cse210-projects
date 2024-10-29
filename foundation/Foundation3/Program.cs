using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running r = new Running(DateTime.Now, 30, 4.8);
        StationaryBike sb = new StationaryBike(DateTime.Now, 45, 15);
        SwimmingLaps sl = new SwimmingLaps(DateTime.Now, 60, 15);
        activities.Add(r);
        activities.Add(sb);
        activities.Add(sl);
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}