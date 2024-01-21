using System;
using System.Threading.Channels;

namespace App
{
    class Yanmife
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Console.Write("Enter your name: ");
                //var Name = Console.ReadLine();
                //Console.WriteLine(Name);
                //if (String.IsNullOrEmpty(Name)) { break; }

                Console.Write("Type your name: ");
                var input= Console.ReadLine();

                if (!String.IsNullOrEmpty(input) )
                {
                    Console.WriteLine(input);
                    continue;
                }
                break;
               
            }
        }
    }
}