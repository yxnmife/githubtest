using System;

using System.Collections.Generic;
namespace WorkingwLists
{
    class yanmife
    {
        public static void Main(string[] args)
        {
            var fruits = new List<string>() { "Apple", "Banana", "Orange" };
            fruits.Add("Grape");
            Console.WriteLine("This is List of fruits: ");
            fruits.AddRange(new string[3] {"Watermelon","Pear","Strawberry"});
            fruits.Add("Orange");
            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("The index of 'Orange' is: "+fruits.IndexOf("Orange"));
            Console.WriteLine("The last index of 'Orange' is: " + fruits.LastIndexOf("Orange"));
            Console.WriteLine("Count: " +fruits.Count);

            fruits.Remove("Grape");
            foreach(var item in fruits) Console.WriteLine(item);
        }
    }
}
