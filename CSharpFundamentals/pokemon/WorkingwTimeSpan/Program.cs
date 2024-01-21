using System;
using System.Collections.Generic;

namespace WorkingwTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var Timespan1 = new TimeSpan(1, 3, 3);
            var Timespan2= TimeSpan.FromHours(1);
            Timespan2 += TimeSpan.FromMinutes(30);
            Console.WriteLine("Timespan2 total minutes: "+Timespan2.TotalMinutes);

            var Timespan3=new TimeSpan(0, 7,0);
            Timespan1 += Timespan3;
            Console.WriteLine("Timespan1 TotalHours: "+Timespan1.TotalHours);

            Console.WriteLine("Minutes: "+Timespan1.Minutes);
            Console.WriteLine("TotalMinutes: "+Timespan1.TotalMinutes);

            Timespan2 += new TimeSpan(0, 7, 0);
            Console.WriteLine("Total minutes: "+Timespan2.TotalMinutes);

            Console.WriteLine("Timespan3 total seconds: "+Timespan3.TotalSeconds);

            Console.WriteLine("Timespan3 increased minutes: "+Timespan3.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Timespan3 reduced minutes: "+Timespan3.Subtract(TimeSpan.FromMinutes(2)));

            Console.WriteLine("Parse: "+TimeSpan.Parse("01:30:00"));
        }
    }
}