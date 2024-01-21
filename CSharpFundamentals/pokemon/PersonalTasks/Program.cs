using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Threading.Channels;

class Program
{
    public static void Main(string[] args)
    {
        //Exercise1();
        //Exercise2();
        //Exercise3();
        //Exercise4();
        // Exercise5();
        Exercise6();
    }

    static void Exercise1()
    {
        Console.Write("Enter a number to be divided: ");
        var divisible = Console.ReadLine();
        var Divisiblenum = Convert.ToInt32(divisible);

        Console.Write("Enter the divisor: ");
        var divisor = Console.ReadLine();
        var Divisornum = Convert.ToInt32(divisor);



        var count = 0;
        for (int i = 1; i <= Divisiblenum; i++)
            if (i % Divisornum == 0)
            {
                count++;
            };
        Console.WriteLine("The number of numbers divisible by " + divisor + " is:" + count);
    }
    static void Exercise2()
    {
        string close = "close";
        var sum = 0;


        while (true)
        {
            Console.Write("clos\nEnter a number or type '" + close + "' to exit: ");
            var UserInput = Console.ReadLine();


            if (UserInput.ToLower() == close.ToLower())
            {
                Console.WriteLine("Session Terminated!");
                return;
            }
            if (int.TryParse(UserInput, out int number))
            {
                Console.WriteLine("The number your entered is: " + number);
            }
            else { Console.WriteLine("You entered a wrong input, try again."); }


            sum += Convert.ToInt32(UserInput);
            Console.WriteLine("The sum of the previous numbers is: " + sum);
        }

    }
    static void Exercise3()//password generator
    {
        var close = "close";

        while (true)
        {
            var passwordlength = 8;
            var entry = new char[passwordlength];
            Random Randomgenerator = new Random();

            Console.Write("Enter your FirstName or type '" + close + "' to exit: ");
            var FirstName = Console.ReadLine();

            if (FirstName.ToLower() == close.ToLower())
            {
                Console.WriteLine("Session Terminated");
                return;
            }

            for (var i = 0; i < passwordlength; i++)
            {
                entry[i] = (char)+('a' + Randomgenerator.Next(0, 26));


            }
            var password = new string(entry);
            Console.WriteLine("The password for " + FirstName + " is: " + password);
        }
    }
    static void Exercise4()//Fctorial generator
    {
        var factorial = 1;
        Console.Write("Enter a number: ");
        var number = Convert.ToInt32(Console.ReadLine());
        for (var i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }
    static void Exercise5()//Guess the secret number
    {
        Random Numgenerator = new Random();
        var entries = 4;
        var secretno = Numgenerator.Next(1, 10);
        Console.WriteLine("the secret no is: " + secretno);
        for (var i = 0; i < entries; i++)
        {
            Console.Write("Guess the secret number: ");
            var guess = Convert.ToInt32(Console.ReadLine());

            if (guess == secretno)
            {
                Console.WriteLine("You won! ");
                return;
            }
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("You lost");

    }
    static void Exercise6()//maximum number
    {
        Console.Write("enter a series of numbers separated by comma: ");
        var UserInput = Console.ReadLine();
        var separated = UserInput.Split(',');
        var max = Convert.ToInt32(separated[0]);


        foreach (var item in separated)
        {
            var numbers = int.Parse(item);
            if (numbers > max)
            {
                max = numbers;
            }
        }
        Console.WriteLine("The maximum number is: " + max);
    }
}


