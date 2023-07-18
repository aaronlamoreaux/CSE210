using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(30, 4, 0, 0));

        activities.Add(new Cycling(30, 0, 7, 0));

        activities.Add(new Swimming(30, 0, 0, 0, 5));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.Summary());
        }
    }
}