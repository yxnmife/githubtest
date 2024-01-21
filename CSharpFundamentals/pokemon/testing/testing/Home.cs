using System;

namespace pokemon
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        
        public string DriverName;
        public int DriverAge;
        public void DriverInfo()
        {
            Console.WriteLine("The name of our driver is "+DriverName+" and he's "+ DriverAge);
        }
        public void Introduce()
        {
            Console.WriteLine("My name is "+FirstName+" "+LastName);
        }
        public void slogan()
        {
            Console.WriteLine("You can't see me! ");
        }
      
    }
    
}