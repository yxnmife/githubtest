using System;
namespace pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float a = 40.45f;
                int b = (int)a;
                Console.WriteLine(b);
                var x = "True";
                bool y=Convert.ToBoolean(x);
                Console.WriteLine(y);

            }
            catch (Exception)
            {
                Console.WriteLine("Error! Could not handle code");
            }
        }
    }
}