using Arrays;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Array
{
    public class Work
    {
        public static void Main(string[] args)
        {
            var FirstName = "Yanmife";
            var LastName = "Ayeni";
            var FullName = FirstName + " " + LastName;

            var names = new string[3] { "John", "David", "King" };
            var formattednames=string.Join(", ", names);

            var text = @"Hi John, check this directory for that file
C:\Users\Yanmife\Documents\School\Folder2";
           
            string MyFullName=string.Format("My name is {0} {1}",FirstName,LastName);

            Console.WriteLine(MyFullName);
            Console.WriteLine(formattednames);
            Console.WriteLine(text);

            {
                var work = Colors.Purple;
                Console.WriteLine((int)work);

                var workId = 0;
                Console.WriteLine((Colors)workId);
            }
            var FruitArray = new string[3][];
            FruitArray[0] =["Apple","Orange","PineApple"];
            FruitArray[1] = ["Carrot", "Lettuce", "Broccoli"];
            FruitArray[2] = ["Yam", "Cassava", "Potato"];
           

            var BirthCertificates = new string[3] { "Yanmife", "Ayeni", "Iyanu" };
            var Name = new List<string>();
            foreach(var item in BirthCertificates)
            {
                Name.Add(item);
            }
            var Converts= String.Join(" ", Name);
            Console.WriteLine(Converts);
            Console.WriteLine("Index: "+Converts.IndexOf("Ayeni"));

            var Test = new List<string> { "GEC", "EDS", "TMC" };
            Console.WriteLine(Test[2]);
        }
    }
}