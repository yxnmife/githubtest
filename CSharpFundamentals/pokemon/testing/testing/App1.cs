using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using testing.Math;
using pokemon;

namespace testing
{

    class Program
    {
        static void Main(string[] args)
         {
            Person John = new Person();
            John.FirstName = "John";
            John.LastName = "Cena";
            John.Introduce();
            John.slogan();

            CalcAdder calculator = new CalcAdder();
            var result = calculator.Add(10, 25);
            Console.WriteLine(result);

            Person Driver1 = new Person();
            Driver1.DriverName = "Ikhalea David";
            Driver1.DriverAge = 24;

            Driver1.DriverInfo();

            cars bugatti = new cars();
            int miles = 30;
            bugatti.drive();

        }
       



        }



    }
  
