using System;

namespace testing.Math
{
    public class Peoples
    {
        public string name;
        private string Name
        {
            get { return name; }
            set { value = name; }
        }

            static void Main(string[] args)
        {
            Peoples Jayson = new Peoples();
            Jayson.name = "Jayson";
        }
    }

    }