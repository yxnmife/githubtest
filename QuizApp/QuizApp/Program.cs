using System;
using System.Collections.Generic;
using System.Text;
namespace QuizApp
{
    public class Questions
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Answer the following questions to determine how patriotic you are.");
            Question1();
            Question2();
            Question3();
            Question4();

        }
       private static void Question1()
        {
            var Alphabets = new List<string> { "A", "B", "C", "D" };
            var Presidents = new List<string> { "Shehu Shagari", "Bola-Ahmed Tinubu", "Mohammed Buhari", "Goodluck Jonathan" };
            var FirstName = Presidents[0];
           
                Console.WriteLine("Who is the current president of Nigeria: ");
            for (var i = 0; i < Alphabets.Count; i++)
            {
                foreach (var item in Alphabets)
                {
                    Console.WriteLine(item +": "+Presidents[i]);
                    Presidents.Remove(Presidents[i]);
                }
                break;
            }
            var Correct = "B";
            ForAnswer(Correct);
        }
        private static void Question2()
        {
            var Alphabets = new List<string> { "A", "B", "C", "D" };
            var Years = new List<int> { 1960, 1961, 1962, 1963 };
            var FirstYear = Years[0];



            Console.WriteLine("\n"+"What Year did Nigeria gain Independence: ");
            for (var i = 0; i < Alphabets.Count; i++)
            {
                foreach (var item in Alphabets)
                {
                    Console.WriteLine(item + ": " + Years[i]);
                    Years.Remove(Years[i]);
                }
                break;
            }
            var Correct = "D";
            ForAnswer(Correct);
            
        }
        private static void Question3()
        {
            var Alphabets = new List<string> { "A", "B", "C", "D" };
            var Numbers = new List<int> { 1, 2, 3, 4 };
            var FirstNumber = Numbers[0];



            Console.WriteLine("\n" + "How many stanzas are in the Nigerian national anthem: ");
            for (var i = 0; i < Alphabets.Count; i++)
            {
                foreach (var item in Alphabets)
                {
                    Console.WriteLine(item + ": " + Numbers[i]);
                    Numbers.Remove(Numbers[i]);
                }
                break;
            }
            var Correct = "B";
            ForAnswer(Correct);

        }
        static void Question4()
        {
            var Alphabets = new List<string> { "A", "B", "C", "D" };
            var States = new List<string> {"Ogun","Lagos","FCT","Anambra"};
            var FirstState = States[0];



            Console.WriteLine("\n" + "Where is  the capital of Nigeria: ");
            for (var i = 0; i < Alphabets.Count; i++)
            {
                foreach (var item in Alphabets)
                {
                    Console.WriteLine(item + ": " + States[i]);
                    States.Remove(States[i]);
                }
                break;
            }
            var Correct = "C";
            ForAnswer(Correct);
        }
            public static void ForAnswer(string Correct)
        {
            while (true)
            {
                Console.Write("\nAnswer: ");
                var Answer = Console.ReadLine();


                if (!String.IsNullOrWhiteSpace(Answer))
                {
                    if (Answer == Correct.ToLower())
                    {
                        Console.WriteLine("Correct, that is the right answer.");
                        return;
                    }
                    else if (Answer != Correct.ToLower())
                    {
                        Console.WriteLine("Incorrect, that is the wrong answer.");
                    }
                }
                else { Console.WriteLine("You have entered an Invalid Input."); }


            }
        }
    }
}
