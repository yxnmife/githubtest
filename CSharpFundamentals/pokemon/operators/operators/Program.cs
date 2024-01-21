using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARITHMETIC OPERATIONS

            int a = 4;
            int b = a++;//this is going to first assign a to b, then increment a by 1
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c = 9;
            int d = ++c;//this is going to first increment c, then b and c will be the same value
            Console.WriteLine(c);
            Console.WriteLine(d);

            //COMPARISON OPERATIONS

            var name = "Yanmife";
            var sname = "Yanmife";
            Console.WriteLine(name==sname);
            Console.WriteLine(name!="Yanmife");
            Console.WriteLine((c>a)||(b>a));

            //ASSIGNMENT OPERATORS
            float pricelist = 15.67f;
            int newprice = (int)pricelist;
            newprice += 3;
            var numb = "1000";
            int Numb = Convert.ToInt32(numb);
            Numb += 100;
            Numb *= 2;
            Numb /= 11;
            Console.WriteLine(Numb);
            Console.WriteLine(newprice);
        }
    }
}