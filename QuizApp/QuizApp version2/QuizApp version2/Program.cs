using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuizApp.QuizApp_V2
{
    public class QuizApp_version2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Answer the following questions to determine how patriotic you are.");


            var Alphabets = new List<string> { "A", "B", "C", "D" };
            var Presidents = new List<string> { "Shehu Shagari", "Bola-Ahmed Tinubu", "Mohammed Buhari", "Goodluck Jonathan" };
            var FirstName = Presidents[0];

            Console.WriteLine("Who is the current president of Nigeria: ");
            for (var i = 0; i < Alphabets.Count; i++)
            {
                foreach (var item in Alphabets)
                {
                    Console.WriteLine(item + ": " + Presidents[i]);
                    Presidents.Remove(Presidents[i]);
                }
                break;
            }
            var Correct = "B";
            var score0= ForAnswer(Correct);

            var Years = new List<int> { 1960, 1961, 1962, 1963 };
            var FirstYear = Years[0];

            Console.WriteLine("\n" + "What Year did Nigeria gain Independence: ");
            for (var i = 0; i < Alphabets.Count; i++)
            {
                foreach (var item in Alphabets)
                {
                    Console.WriteLine(item + ": " + Years[i]);
                    Years.Remove(Years[i]);
                }
                break;
            }
            var Correct1 = "D";
           var score1= ForAnswer(Correct1);

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
            var Correct2 = "B";
            var score2=ForAnswer(Correct2);

            var States = new List<string> { "Ogun", "Lagos", "FCT", "Anambra" };
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
            var Correct3 = "C";
          var score3= ForAnswer(Correct3);


            var Names = new List<string> { "Mike Adenuga", "Aliko Dangote", "Jim Ovia", "Tony Elumelu" };
            var Name = Names[0];

            Console.WriteLine("\n" + "Who is the richest man in Nigeria: ");
            for (var i = 0; i < Alphabets.Count; i++)
            {
                foreach (var item in Alphabets)
                {
                    Console.WriteLine(item + ": " + Names[i]);
                    Names.Remove(Names[i]);
                }
                break;
            }
            var Correct4 = "B";
            var score4 = ForAnswer(Correct4);

         

            var Total = (score0 + score1 + score2 + score3 + score4);
            Console.WriteLine("Your Total score is: "+Total+"/100");

        }
        public static int ForAnswer(string Correct)
        {
            var points = 0;
            Console.Write("\nAnswer: ");
            var Answer = Console.ReadLine();


            if (!String.IsNullOrWhiteSpace(Answer))
            {
                if (Answer == Correct.ToLower())
                {
                    Console.WriteLine("Correct, that is the right answer.");
                    points += 20;
                }
                else if (Answer != Correct.ToLower())
                {
                    Console.WriteLine("Incorrect, that is the wrong answer.");
                }
            }
            else
            {
                Console.WriteLine("You have entered an Invalid Input.");
            }
            
            return points;
        }
    }
}