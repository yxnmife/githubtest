using System;

namespace Defclasses
{
    public class Car
    {
        string Brand = "Toyota";
        string color = "red";
        string name;
        int year;
        
        static void Main(string[] args)
        {
            Car Corolla = new Car();
            Corolla.name = "Corolla";
            Corolla.year = 2012;

            Car Avalon = new Car();
            Avalon.name = "Avalon";
            Avalon.year = 2015;

            Car Camry = new Car();
            Camry.name = "Camry";
            Camry.year = 2010;
            Camry.color = "green";

            Console.WriteLine(Avalon.year);
            Console.WriteLine(Camry.name);
            Console.WriteLine(Corolla.color);
            Console.WriteLine(Camry.color);
        }
    }
}