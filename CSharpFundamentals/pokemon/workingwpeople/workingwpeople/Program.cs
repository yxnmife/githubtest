using System;

namespace workingwipeople
{
    public class People
    {
        public string name;
        public string sname;
        public int age;
        public string color;

        public void Details(string Name, string SName, int Age)
        {
            name= Name;
            sname = SName;
            age = Age;
        }
        public void Info()
        {
            Console.WriteLine("My name is "+name+" "+sname+" aged "+age);
        }
      class Location
        {
            private string nation;
            private string university;
            public void Details2(string Nation, string University)
            {
                nation = Nation;
                university = University;
            }
            public void Information()
            {
                Console.WriteLine("I attended " + university + " " + nation);
            }
        }
        static void Main(string[] args)
        {
            People Yanmife = new People();
            Yanmife.Details("Yanmife", "Ayeni", 23);
            Yanmife.Info();

            People David = new People();
            David.Details("David", "Ikhalea", 25);
            David.color = "black";
            David.Info();
            Console.WriteLine(David.color);

            Location YanmifeLocation=new Location();
            YanmifeLocation.Details2("Nigeria","Covenant Univeristy");
            YanmifeLocation.Information();

            Location DavidLocation= new Location();
            ;
            DavidLocation.Details2("United Kingdom", "Oxford");
            DavidLocation.Information();

        }
    }
}