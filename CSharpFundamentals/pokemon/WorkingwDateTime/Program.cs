using System;

namespace WorkingwDateTime
{
    public class Yanmife
    {
        static void Main(string[] args)
        {
           var Datetime= new DateTime(2023,11,14);
          

           // var Today = DateTime.Today;
          
          

           //var tomorrow= Now.AddDays(1);
           // Console.WriteLine(tomorrow);
           var TodayDate=DateTime.Now;
            var Now=DateTime.Now;
             Console.WriteLine("Hour: "+Now.Hour);
            Console.WriteLine("Seconds: "+Now.Second);
             Console.WriteLine("Date: " + Now.Date);
            Console.WriteLine("==============================");
            var Tomorrow =TodayDate.AddDays(1);
            var TwoDaysAgo=TodayDate.AddDays(-2);

            //Console.WriteLine("Tomorrow: "+Tomorrow.Date);
            //Console.WriteLine("Two days ago: "+TwoDaysAgo.Date);

            Console.WriteLine("Long Date:"+TodayDate.ToLongDateString());
            Console.WriteLine("Short Date: "+TodayDate.ToShortDateString());
            Console.WriteLine("Long Time: "+TodayDate.ToLongTimeString());
            Console.WriteLine("Short Time: "+TodayDate.ToShortTimeString());
            Console.WriteLine("DATE AND TIME: "+TodayDate.ToString());
            Console.WriteLine("today's day: "+TodayDate.ToString("dddd"));
            //for all date and time


        }
    }
}