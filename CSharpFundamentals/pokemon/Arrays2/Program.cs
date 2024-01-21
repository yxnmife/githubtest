using System;

namespace Arrays2
{
    public class App
    {
        static void Main(string[] args)
        {
            var numbers = new int [] { 1, 2, 3, 4, 5 };
            var numbers2 = new int [3];
            Console.WriteLine("Length of the array: " + numbers.Length);

            var index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Index: " + index);

            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of clear method: ");
            foreach (var str in numbers) 
            { 
            Console.WriteLine(str);
            }
            Array.Copy(numbers, numbers2, 3);
            Console.WriteLine("Effect of copy method");
            foreach(var item in numbers2)
            {
                Console.WriteLine(item);
            }
           
        }
    }
} 