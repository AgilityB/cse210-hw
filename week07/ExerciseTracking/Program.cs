// Adding Weekly Summary as advanced requirement

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 4), 45, 15.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 5), 40, 20));

        activities.Add(new Running(new DateTime(2022, 11, 10), 25, 2.5));
        activities.Add(new Cycling(new DateTime(2022, 11, 11), 60, 14.0));

        Console.WriteLine("=== Individual Activities ===\n");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine("\n=== Weekly Summary ===\n");

        var grouped = activities.GroupBy(a => a.GetWeekNumber());

        foreach (var weekGroup in grouped)
        {
            int week = weekGroup.Key;

            double totalDistance = weekGroup.Sum(a => a.GetDistance());
            double totalMinutes = weekGroup.Sum(a => a.GetMinutes());
            double avgSpeed = (totalDistance / totalMinutes) * 60;
            double avgPace = totalMinutes / totalDistance;

            Console.WriteLine($"Week {week}:");
            Console.WriteLine($"  Total Distance: {totalDistance:0.0} miles");
            Console.WriteLine($"  Average Speed: {avgSpeed:0.0} mph");
            Console.WriteLine($"  Average Pace: {avgPace:0.0} min per mile\n");
        }
    }
}
