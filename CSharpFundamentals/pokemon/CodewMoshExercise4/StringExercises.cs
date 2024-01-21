using System;
using System.Collections.Generic;
using CodewMoshExercise4;
using System.Linq;
namespace Yanmife
{
    public class App
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Test();
            Test2();

        }
        static void Exercise1()
        {
            Console.Write("Enter a few numbers separated by a hyphen (-): ");
            var UserInput = Console.ReadLine();
            var Inputs = UserInput.Split("-");
            var Numbers = new List<int>();
            var Duplicates = new List<int>();

            foreach (var input in Inputs)
            {
                Numbers.Add(int.Parse(input));

            }
            Numbers.Sort();
            foreach (var input in Numbers)
            {
                for (var i = 0; i < Numbers.Count - 1; i++)
                {

                    if (!(Numbers[i + 1] == (Numbers[i] + 1)))
                    {
                        Console.WriteLine("Not Consecutive");
                        return;
                    }

                }

            }
            Console.WriteLine(" Consecutive");
        }

        static void Exercise2()
        {
            Console.Write("Enter a few numbers separated by a hyphen (-): ");
            var UserInput = Console.ReadLine();
            var Input = UserInput.Split("-");
            var Numbers = new List<int>();
            var Duplicates = new List<int>();


            if (string.IsNullOrWhiteSpace(UserInput))
            {
                Console.WriteLine("Exiting.....");
                return;
            }
            foreach (var value in Input)
            {
                var convert = int.Parse(value);
                Numbers.Add(convert);
            }
            foreach (var items in Numbers)
            {
                if (!Duplicates.Contains(items))
                {
                    Duplicates.Add(items);
                }
                else
                {
                    Console.WriteLine("Duplicate Item detected! ");
                    return;
                }
            }
            Console.WriteLine("No duplicate item.");
        }
        static void Exercise3()
        {
            var Numbers = new List<int>();
            Console.Write("Enter a time value in the 24 hour format (e.g 19:00): ");
            var UserInput = Console.ReadLine();
            var User = UserInput.Split(":");
            foreach (var item in User)
            {
                var convert = int.Parse(item);
                Numbers.Add(convert);
            }
            if (Numbers[0] <= 23 && Numbers[1] <= 59)
            {
                Console.WriteLine("Ok");
                return;
            }
            Console.WriteLine("Invalid time");
        }

        static void Exercise4()
        {
            Console.Write("Enter a few words separated by space: ");
            var UserInput = Console.ReadLine().ToLower();
            var Entry = UserInput.Split(" ");

            var PascalList = new List<string>();
            foreach (var item in Entry)
            {
                var FirstCharlower = item[0];
                var FirstCharupper = char.ToUpper(FirstCharlower);//converts char to uppercase
                //var Chararray=FirstCharlower.ToCharArray();
                //var char1 = Chararray[0];
                //var modifiedword = item.Replace(Item[0], char1);
                var modifiedword = item.Replace(FirstCharlower, FirstCharupper);
                PascalList.Add(modifiedword);
            }
            var Output = string.Join("", PascalList);
            Console.WriteLine("Output in PascalCase: " + Output);
        }
        static void Exercise5()
        {
            Console.Write("Enter an english word: ");
            var UserInput = Console.ReadLine().ToLower();
            var Vowelcount = 0;

            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var Characters = new List<char>(vowels);

            foreach (var item in UserInput)
            {
                if (Characters.Contains(item))
                {
                    Vowelcount += 1;
                }

            }

            Console.WriteLine("Total no of vowels: " + Vowelcount);
        }
        static void Test()
        {

            Console.Write("Enter a number: ");
            var userInput = Console.ReadLine();
            var count = 0;

            if (int.TryParse(userInput, out int num))
            {
                var divisor = 4;

                count = num / divisor;
                Console.WriteLine($"Count of numbers divisible by {divisor} is: {count}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        static void Test2()
        {
            var ReversedNames = new List<char>();
            while (true)
            {
                var close = "close";
                Console.Write("Enter the name to be reversed or type 'close' to exit: ");
                var UserInput = Console.ReadLine();
                if (UserInput == close)
                {
                    Console.WriteLine("Session Terminated!");
                    return;
                }

                var Name = UserInput.Split("");
                var Combination=new List<string>();

                foreach(var item in Name)
                {
                        Combination.Add(item);
                }
                

                foreach (var item in Combination)
                {
                    var Wordlength = item.Length;
                    Console.WriteLine("Name: " + item);

                    for (var i = Wordlength - 1; i >= 0; i--)
                    {
                        
                        ReversedNames.Add(item[i]);
                    }
                }
                var name = ReversedNames.ToArray();
                Console.WriteLine("Reversed Name: " + string.Join("", name));
                Console.WriteLine("=========================================");

            }
        }
    }
}