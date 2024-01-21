using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefClasses
{
    public class Person
    {
        string Name;
        string SName;
        int age;
        static void Main(string[] args)
        {
            Person APC = new Person();
           // APC.Name = "Yemi";
            APC.SName = "Osinbajo";
            APC.age = 65;

            APC.Name = "Bola-Ahmed";
            APC.SName = "Tinubu";
            APC.age = 81;



            Console.WriteLine(APC.Name);

        }
    }
}
