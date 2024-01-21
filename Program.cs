using System;
using System.Collections.Generic;

namespace ToDolist
{
    public class Program
    {
        public static void Main(string[] args)
        {
            App();
        }


        static void App()
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
                if(!int.TryParse(Entry,out int EntryNum))
                {
                    Console.WriteLine("Wrong Input, enter a valid Input number");
                }
                
            }
        }
    }
}