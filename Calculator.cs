using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Calculator
{
    public class Yanmife
    {
        public static void Main(string[] args)
        {
            var add = "+";
            var subtract = "-";
            var multiply = "*";
            var divide = "/";
            var close = "close";

            Console.WriteLine("Enter the arithmetic operator '" + add + "' for addition. ");
            Console.WriteLine("Enter the arithmetic operator '" + subtract + "' for subtraction. ");
            Console.WriteLine("Enter the arithmetic operator '" + multiply + "' for multiplication. ");
            Console.WriteLine("Enter the arithmetic operator '" + divide + "' for division. ");



            while (true)
            {
                Console.Write("\nEnter the aritmetic operator you wish to use or type '" + close + "' to exit: ");
                var UserInput = Console.ReadLine();
              
                    if (UserInput == close)
                    {
                        Console.WriteLine("Session Terminated, THANK YOU!.");
                        return;
                    }

                   else if (UserInput == add)
                    {
                    Console.Write("\nEnter the first Number: ");
                    float FirstNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nEnter the second Number: ");
                    float SecondNum = Convert.ToInt32(Console.ReadLine());

                    var result = FirstNum + SecondNum;
                    Console.WriteLine("Result of Addition: " + result);
                    }
                   else if (UserInput == subtract)
                    {
                    Console.Write("\nEnter the first Number: ");
                    float FirstNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nEnter the second Number: ");
                    float SecondNum = Convert.ToInt32(Console.ReadLine());

                    var result = FirstNum - SecondNum;
                        Console.WriteLine("Result of Subtraction: " + result);
                    }
                   else if (UserInput == divide)
                    {
                    Console.Write("\nEnter the first Number: ");
                    float FirstNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nEnter the second Number: ");
                    float SecondNum = Convert.ToInt32(Console.ReadLine());

                    var result = FirstNum / SecondNum;
                        Console.WriteLine("Result of Division: " + result);
                    }
                    else if (UserInput == multiply)
                    {
                    Console.Write("\nEnter the first Number: ");
                    float FirstNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nEnter the second Number: ");
                    float SecondNum = Convert.ToInt32(Console.ReadLine());

                    var result = FirstNum * SecondNum;
                        Console.WriteLine("Result of Multiplication: " + result);
                    }
                else { Console.WriteLine("Please enter a valid input."); }
            }
        }
      
        
    
        
    }
}
