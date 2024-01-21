using System;
using System.Collections.Generic;
namespace Testing
{
    public class Classroom
    {
        public static void Main(string[] args)
        {
            //Naming();
            //Exercise5();
            WorkingwithStrings();
        }

        static void Naming()//Initials generator 
        {
            var list = new List<string>();
            var initials = new List<char>();

            Console.Write("Enter your firstname: ");
            var Firstname = Console.ReadLine();

            Console.Write("Enter your Lastname: ");
            var Lastname = Console.ReadLine();

            Console.Write("Enter your Middlename: ");
            var Middleame = Console.ReadLine();

            var NameArray = new string[] { Firstname, Lastname, Middleame };
            foreach (var item in NameArray)
            {
                var converted = item.ToString();
                list.Add(converted);
                initials.Add(converted[0]);

            }
            var Names = string.Join(' ', list);
            var Initials = string.Join("", initials);

            Console.WriteLine("Your names are: " + Names);
            Console.WriteLine("Your initials are: " + Initials.ToUpper());

        }
        static void Numberdoubler()
        {

            while (true)
            {
                var close = "close";
                Console.Write("Type '" + close + "' or Enter a number to be multiplied by 2: ");
                var entry = Console.ReadLine();
                if (!string.IsNullOrEmpty(entry))
                {
                    if (entry == close)
                    {
                        Console.WriteLine("Session Terminated");
                        return;
                    }
                    if (int.TryParse(entry, out var number))
                    {
                        int Multiple = number * 2;
                        Console.WriteLine("Double = " + Multiple);
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                    }


                }


            }
        }

        /// <summary>
        /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
        /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        /// the 3 smallest numbers in the list.
        /// 
        /// </summary>
        public void Exercise5()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
       
    }
}