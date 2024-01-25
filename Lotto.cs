using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Lotto
{
    public class Program
    {
        public string UserInput;
        public static void Main(string[] args)
        {
           
          
            Winnings();
        }
        static string Validator()
        {
            Console.WriteLine("Welcome to the Winners Golden Lotto \nTry and guess the three digit number to win the prize.\n");
            Console.Write("Guess the three digit lucky numbers: ");
            var UserInput = Console.ReadLine();
            var count = 3;

            if(string.IsNullOrEmpty(UserInput))
            {
                throw new ArgumentNullException("Input cannot be null");
            }
            if(UserInput.Length != count)
            {
                throw new ArgumentException("Input should be three digits");
            }
            Console.WriteLine("\nYour Guess: "+UserInput);
            return UserInput;

        }
        static string LottoMachine()
        {
            Random random = new Random();
            var Lucky = new List<int>();
            
            var count = 3;
            for (var i = Lucky.Count; i<count;i++ )
            {
                var ran =random.Next(0, 9);
                Lucky.Add(ran);
            }
            var LuckyNumber = string.Join("", Lucky);
            Console.WriteLine("The lucky number is: " +LuckyNumber+"\n") ;
            Console.WriteLine("==========================================================================");
            return LuckyNumber;
        }
        static void Winnings()
        {
            if (Validator() == LottoMachine())
            {
                Console.WriteLine("Congratulations!,You just won $1,000,000.");
            }
            else { Console.WriteLine("I'm sorry, you lost. Try again later."); }
            return;
        }
    }
 }