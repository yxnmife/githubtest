using System;
using System.Collections.Concurrent;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise
{
    public class App
    {
        public static void Main()
          
        {
            //Exercise1();
            //Exercise2();
            //Exercise3()
            //Exercise4()
            Exercise2();
        }


        static void Exercise1()
        {
            var count = 0;
            for(int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("the number of numbers divisible by 3 is: " + count);
        }
        static void Exercise2()
        {
            var close = "ok";
            var sum = 0;
           
           

            while (true)
            {
                Console.Write("Enter a number or type '" + close + "' to exit: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == close.ToLower())
                {
                    Console.WriteLine("Session Terminated");
                    return;
                }
                if (int.TryParse(entry, out int Number))
                    {
                    Console.WriteLine("The number you entered is: "+Number);
                     }
                else { Console.WriteLine("Wrong Input, Try again: "); }

                sum += Convert.ToInt32(entry);
                Console.WriteLine("The sum of all th7e numbers entered is: " + sum);

            }
           
        }
        static void Exercise3()
        {
            Console.Write("Enter a number: ");
          
            var number=Convert.ToInt32(Console.ReadLine());
            var factorial=1;

            for(var i = 1; i <= number; i++)
            {
                factorial *= i;
                Console.WriteLine("The factorial of "+number+" sis: "+factorial);

            }
           
        }
       static void Exercise4()
        {
            Random random= new Random();
            var guess = random.Next(1, 10);
            Console.WriteLine("The lucky number is: "+guess);
            const int chances = 4;

            for(var i=0; i<chances; i++)
            {
                Console.Write("Guess the lucky number: ");
                var secretno = Convert.ToInt32(Console.ReadLine());
                if (secretno == guess)
                {
                    Console.WriteLine("You won! ");
                    return;
                }
            }
            Console.WriteLine("You lost, sorry. ");
        }
        static void Exercise5()
        {
            Console.Write("Enter a series of numbers separated by ',': ");
            var UserInput= Console.ReadLine();
            var numbers = UserInput.Split(',');
            var max = Convert.ToInt32(numbers[0]);



            foreach (var str in numbers)
            {

                var ConvertedString = Convert.ToInt32(str);
                if (ConvertedString > max) {
                  

                    max = ConvertedString;
            }
               
            }
            Console.WriteLine("The maximum value is " + max);
        }

    }
    
}