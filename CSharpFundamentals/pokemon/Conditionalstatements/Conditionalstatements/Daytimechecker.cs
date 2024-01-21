using System;
using System.Threading.Channels;
using Conditionalstatements;

namespace Work
{
    public class Program
    {
        public int time;
        public int mintime;
        public int maxtime;
        public string month;

        static void Main(string[] args)
        {
            Console.Write("Enter the time: ");
            var time = int.Parse(Console.ReadLine());

            if (time >= 0 && time < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time >= 12 && time < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else
            {
                { Console.WriteLine("Good night"); }
            }

            var methodId = 2;
            var season =Season.Spring;
            Console.WriteLine((Season)methodId);

            Console.Write("Enter the month: ");
            var Month = Console.ReadLine();

            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("The current season is Spring");
                    break;
                case Season.Summer:
                case Season.Winter:
                case Season.Autumn:
                    Console.WriteLine("The current season is not Spring");
                    break;
                default:
                    Console.WriteLine("Error!!");
                    break;
            }
           
        }



        }
    }