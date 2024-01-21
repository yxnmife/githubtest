using System;
using CodewMosh_Excercise;

namespace Excercise
{
    public class Excercise
    {
        public int number;
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1-10: ");

            var number = int.Parse(Console.ReadLine());
            if (number>=1 &&number<11 )
            {
                Console.WriteLine("Valid!, this number is between 1 -10 ");
            }
            else
            {
                Console.WriteLine("Invalid!, this number is not between 1-10 ");
            }
            Console.Write("Enter the first number: ");
            var number1=int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            var number2=int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("The higher number is "+number1);
            }
            else
            { Console.WriteLine("The higher number is "+number2); }


            Console.Write("Enter the value for the width: ");
            var width = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for the height: ");
            var height = int.Parse(Console.ReadLine());

            if (width > height) { Console.WriteLine("Your phone is in Landscape mode "); }
            else if (height > width) { Console.WriteLine("Your phone is in Portrait smode"); }
            else { Console.WriteLine("Your phone orientation is EVEN"); }

            Console.Write("Enter the speed of the car: ");
            var carspeed=int.Parse(Console.ReadLine());

            Console.Write("Enter the speed limit: ");
            var speedlimit=int.Parse(Console.ReadLine());

            if (carspeed<speedlimit) { Console.WriteLine("OK! "); }
            else
            {
                const int KmPerDemeritPoints = 5;
                int DemeritPoints = (carspeed-speedlimit)/KmPerDemeritPoints;

                if (DemeritPoints > 12)
                {
                    Console.WriteLine("License Suspended. ");
                }
                else
                {
                    Console.WriteLine("You have " + DemeritPoints + " Demerit Points, be careful or lose your license.");
                }
                }

            }

        }
       
}