using System;
using System.Collections.Generic;

namespace Yanmife
{
    public class ProceduralProgramming
    {
        public static void Main(string[] args)
        {

            //Console.Write("Enter the name to be reversed or type 'close' to exit: ");
            //var UserInput = Console.ReadLine();
            //var reversed = ReversedName(UserInput);

            //Console.WriteLine("Reversed Name: " + reversed);
            //Console.WriteLine("=========================================");
            Console.Write("Enter a few numbers separated by a hyphen (-): ");
            var UserInput = Console.ReadLine();

            var result=ConsecutiveNumCheck(UserInput);
            Console.WriteLine(result);


        }
        public static string ReversedName(string UserInput)
        {
            var close = "close";
            var ReversedNames = new List<char>();
           
           
               
                if (UserInput == close)
                {
                    Console.WriteLine("Session Terminated!");
                    return null;
                }

                var Name = UserInput.Split("");
                var Combination = new List<string>();

                foreach (var item in Name)
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
            var Reversal= ReversedNames.ToArray();
            var Reversalstring=string.Join("",Reversal);
            return Reversalstring;
            }

        public static string ConsecutiveNumCheck(string UserInput)
        {
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
                        var Message = "Not Consecutive";
                        return Message;
                    }

                }

            }
            var Message1 = " Consecutive";
            return Message1;
        }

    }
}