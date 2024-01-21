using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monthlychecker;

namespace Monthchecker
{
    internal class MonthcheckerApp
    {
        static void Main(string[] args)
        {
            var CurrentMonth = Months.April;

            switch (CurrentMonth)
            {
                case Months.January:
                    Console.WriteLine("We are in January,Happy New Year! ");
                    break;
                case Months.February:
                case Months.March:
                case Months.April:
                    Console.WriteLine("We are in April, take a stroll");
                    break;
                case Months.May:
                case Months.June:
                    Console.WriteLine("Wow, Half way through the year already. ");
                    break;
                case Months.July:
                case Months.August:
                case Months.September:
                case Months.October:
                case Months.November:
                case Months.December:
                    Console.WriteLine("Congrats, You made it to the end of the year. ");
                    break;
                default:
                    Console.WriteLine("Error, wrong Input. ");
                    break;
            }
        }
    }
}