using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace UsingRandomClass
{
    public class PasswordGen
    {
        public static void Main(string[] args)
        {
           
            while (true)
            {
                Console.Write("Please enter your name: ");
                var UserInput = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(UserInput))
                {
                    Console.WriteLine("Welcome " + UserInput.ToUpper() + "!, please wait as we generate your password...");
                    var name = new StringBuilder();
                    name.Append('=', 20);
                    Console.WriteLine(name);
                    PasswordGenerator();
                    return;
                }
                else { Console.WriteLine("\nWrong Input, try again.");
                   
                }
               
            }
        }
        public static string PasswordGenerator()
        {
            Random characters= new Random();
            var length = 8;
            var LetterList = new List<char>();

            for(var i=0; i < length; i++)
            {
                LetterList.Add((char)('a' +characters.Next(0,26)));
            }
            var Password="Password: "+String.Join("",LetterList.ToArray());
            Console.WriteLine(Password);
            return Password;
        }
    }
}