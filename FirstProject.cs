using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;

namespace Collaboration
{
    public class Project1
    {
        public static void Main(string[] args)
        {
            Person();
            var waiting = new StringBuilder();
            waiting.Append('=', 20);
            Console.WriteLine(waiting);

            ToDo_List();
            Console.WriteLine(waiting);
            Console.WriteLine(waiting.AppendLine());

            Console.WriteLine("Your new passkey is generating.....");
            Passkey();
            Console.WriteLine(waiting);

            MinimumNumberSorter();

        }
        static string Person()
        {
            while (true)
            {
                Console.Write("Enter your firstname: ");
                var Name = Console.ReadLine().ToUpper();

                Console.Write("Enter your surname: ");
                var Sname = Console.ReadLine().ToUpper();

                if (!string.IsNullOrWhiteSpace(Name) || (!string.IsNullOrWhiteSpace(Sname)))
                {
                    Console.WriteLine("Welcome! " + Name + " " + Sname);
                    return Name;
                    return Sname;
                }
                else { Console.WriteLine("\nError!!! please enter a name in at least one field to proceed"); }
            }
        }

        static void ToDo_List()
        {
            Console.WriteLine("Type 1 to add to To-Do List: ");
            Console.WriteLine("Type 2 to view to To-Do List: ");
            Console.WriteLine("Type 3 to remove from To-Do List: ");
            Console.WriteLine("Type 4 to exit To-Do List: ");

            var add = "1";
            var view = "2";
            var remove = "3";
            var exit = "4";

            var Entries = new List<string>();
            var index = 0;


            while (true)
            {
                Console.Write("\nType in a number: ");
                var Entry = Console.ReadLine();
                if (Entry == exit)
                {
                    Console.WriteLine("Session Terminated! ");
                    return;
                }
                if (Entry == add)
                {
                    Console.Write("Type in entry for To-Do list: ");
                    var UserInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(UserInput))
                    {
                        Entries.Add(UserInput);
                    }
                    else { Console.WriteLine("Wrong Input, Try again"); }
                }
                if (Entry == view)
                {

                    foreach (var item in Entries)
                    {

                        Console.WriteLine(item);
                    }
                }
                if (Entry == remove)
                {
                    while (true)
                    {
                        Console.Write("Enter the Index of the entry you want to remove: ");
                        var Input = Console.ReadLine();
                        if (int.TryParse(Input, out int NewIndex))
                        {
                            index = NewIndex;
                            var Removed = Entries[index];

                            Console.WriteLine("The item '" + Removed + "' has been removed ");
                            Entries.RemoveAt(NewIndex);
                            break;
                        }
                        else { Console.WriteLine("Please enter a valid index"); }

                    }

                }
                if (!int.TryParse(Entry, out int EntryNum))
                {
                    Console.WriteLine("Wrong Input, enter a valid Input number");
                }

            }
        }
        static string Passkey()
        {
            var Passcode = new List<char>();
            Random random = new Random();
            var passcodelength = 7;
            for (var i = 0; i < passcodelength; i++)
            {
                var character = (char)('a' + random.Next(0, 26));
                Passcode.Add(character);
            }
            var CurrentTime = DateTime.Now;
            var CurrentTimeString = CurrentTime.ToString();

            var Converted = "Password generated at " + CurrentTimeString + " => " + string.Join("", Passcode);
            Console.WriteLine(Converted);
            return Converted;
        }
        static void MinimumNumberSorter()
        {
            var Numbers = new List<int>();
            var MinimumNumbers = new List<int>();

            Console.Write("Enter more than 3 numbers separated by a comma(,): ");
            var UserInput = Console.ReadLine();
            var split = UserInput.Split(',');
            foreach (var item in split)
            {
                if (int.TryParse(item, out int outputs))
                {
                    Numbers.Add(outputs);
                }
            }
            Numbers.Sort();
            var length = 3;
            MinimumNumbers = Numbers.Take(length).ToList();

            var Convert = string.Join(",", MinimumNumbers);
            Console.WriteLine("The three smallest numbers are: " + Convert);
        }

    }
}