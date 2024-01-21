using System;

namespace pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 4;
            int count = 10;
            string[] names = { "John", "James", "Jasmine" };
            float pricelist = 15.75f;
            bool isworking = false;
            var Firstname = "Mosh";
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(names);
            Console.WriteLine(isworking);
            Console.WriteLine(Firstname);
            Console.WriteLine(names[0]+" bought "+ count+ "\nbottles of beer "+
                "for "+pricelist+" each");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        }
    }
}