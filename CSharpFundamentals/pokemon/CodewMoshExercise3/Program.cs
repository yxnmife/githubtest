using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Quic;

public class Yanmife
{
    public static void Main(string[] args)
    {
        //Man();
        //Exercise2();
        Exercise3();
        //Exercise4();
        //Exercise5();
    }
    static void Man()
    {
        var Footballclubs = new List<string>() { "Everton", "Arsenal", "Dortmund", "Augsburg" };
        Footballclubs.Add("Liverpool");
        Footballclubs.AddRange(new string[] { "Bournemouth", "Bayern" });

        foreach (var item in Footballclubs)
        {

            Console.WriteLine(item);
        }
        Console.WriteLine("============================================================");
        var index = Footballclubs.IndexOf("Liverpool");
        Console.WriteLine("The index of 'liverpool' is: " + index);

        Footballclubs.Remove("Liverpool");

        foreach (var item in Footballclubs)
        {

            Console.WriteLine(item);
        }
        Console.WriteLine("============================================================");
        Console.WriteLine("There are " + Footballclubs.Count() + " items in the list.");
    }
    static void Exercise2()//name reverser
    {


        var start = "start";
        var close = "close";


        while (true)
        {
            Console.WriteLine("Type '" + start + "' to start or '" + close + "' to exit: ");
            var entry = Console.ReadLine();
            if (entry == close)
            {
                Console.WriteLine("Session Terminated!");
                return;

            }


            if (entry == start)
            {
                Console.Write("Enter a list of your name in order[firstname,lastname,othername]: ");
                var UserInput = Console.ReadLine();
                var names = UserInput.Split(',');
                {
                    foreach (var item in names)
                    {
                        //
                        var ConvertedNames = new string(item.Reverse().ToArray());
                        Console.WriteLine("Original names: " + item);
                        Console.WriteLine("\nConverted name: " + ConvertedNames);
                        Console.WriteLine("==================================");
                    }
                }
            }
            else
            {
                Console.WriteLine("You entered a wrong input, Try again.");
            }
        }



    }
    static void Exercise3()

    {
        Console.WriteLine("App to display 5 unique numbers in order\n");
        var List = new List<int>();

        while (List.Count < 5)
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int entry))
            {

                if (List.Contains(entry))
                {
                    Console.WriteLine("Number has already been entered");
                    continue;
                }
                List.Add(entry);
                List.Sort();
                //Console.WriteLine("The list of unique numbers: ");
                foreach (var item in List)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Wrong Input, enter a number.");
            }
        }



    }
    static void Exercise4()
    {
        var Quit = "quit";
        var list = new List<int>();

        var uniques = new List<int>();
        while (true)
        {
            Console.Write("Enter a number or type '" + Quit + "' to exit: ");
            var UserInput = Console.ReadLine();


            if (UserInput.ToLower() == Quit.ToLower())
            {
                Console.WriteLine("Session Terminated!");
                return;
            }
            if (int.TryParse(UserInput, out int number))
            {
                list.Add(number);
                uniques =
             list.FindAll(item => list.IndexOf(item) != list.LastIndexOf(item));
                Console.WriteLine("The duplicates in the list are: " + string.Join(',', uniques));
            }else
            { Console.WriteLine("Wrong input, please enter numbers"); }
        }

    }
    static void Exercise5()
    {
        /// <summary>
        /// Write a program and ask the user to supply a list of comma-separated numbers (e.g., 5, 1, 9, 2, 10). If the list is 
        /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        /// the 3 smallest numbers in the list.
        /// </summary>

        string[] entry;
        while (true)
        {
            Console.Write("Enter a list of comma-separated numbers: ");
            var userInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(userInput))
            {
                entry = userInput.Split(',');

                if (entry.Length >= 5)
                {
                    break;
                }
                Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
            }
           
        }

        var numbers = new List<int>();
        foreach (var item in entry)
        {
            if (int.TryParse(item, out int converted))
            {
                numbers.Add(converted);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter valid integers separated by commas.");
                return;
            }
        }

        numbers.Sort(); // Sort the numbers in ascending order

        Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", numbers.Take(3)));
    }

}



