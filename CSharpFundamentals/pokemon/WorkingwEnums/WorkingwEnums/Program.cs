using System;
using System.Security.Cryptography.X509Certificates;

namespace WorkingwEnums
{
    public enum Rainbowcolors
    {
        red=1,
        orange=2,
        yellow=3,
        green=4,
        blue=5,
        indigo=6,
        violet=7,
        white=8,
        black=9,

    }
    public class Program
    {
        public string bag;
        public string hair;
        public void Task()
        {
            Console.WriteLine(bag+" "+hair);
        }
        public static void Main(string[] strings)
        {
            var bag = Rainbowcolors.red;
            Console.WriteLine("The color of my bad is "+bag);

            var suit = 5;
            Console.WriteLine("The color of my suit is "+(Rainbowcolors)suit);

            var hair = 2;
            Console.WriteLine("The color of my hair is "+(Rainbowcolors)hair);

            var shirt = Rainbowcolors.white;
            Console.WriteLine("The am wearing a "+shirt +" shirt");

            var shoe = Rainbowcolors.black;
            Console.WriteLine("The color of my shoe is "+shoe);

            Program Task=new Program();
            Task.bag = "Dior";
            Task.hair = "Braids";
            Task.Task();

            //To test value type

            int a = 4;
            int b = a;
            b++;
            Console.WriteLine(string.Format("a={0},b={1}",a,b));

            //To test reference type

            var array1 = new int[4] { 1, 2, 3, 4 };
            var array2 = array1;
            array2[3] = 10;
            Console.WriteLine(string.Format("array1[3]={0},array2[3]={1}", array1[3], array2[3]));


        }
    }
}