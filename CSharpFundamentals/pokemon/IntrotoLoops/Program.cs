using System;

namespace IntrotoLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var Name = "OLUWAYANMFE";
            var grocerylist = new string[3] { "Yam", "Egg", "Beans" };
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i + "\n"); }

            }
            for (var j = 10; j >= 1; j--)
            {
                if (j % 3 == 0)
                {
                    Console.WriteLine(j + "\n");
                }

                //else { Console.WriteLine("BANG!"); }

            }
            
            foreach (var item in grocerylist)
            {

                Console.WriteLine(item);
            }
           
            }

        }
    }
}
   