using System;

namespace Generator
{
    class Yanmife
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            for (int i = 0; i < 3; i++)

            {
              Console.WriteLine(randomGenerator.Next(1,10));
            }
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for(var i=0; i < passwordLength; i++)
                buffer[i] = (char)('a'+randomGenerator.Next(0,26));

            var password=new string(buffer);
            Console.WriteLine(password);
        }

    }
}