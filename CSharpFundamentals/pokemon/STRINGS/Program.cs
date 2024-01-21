using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace WorkingwString
{
    public class Testing
    {
        static void Main(string[] args)
        {
        //    //Test1();
        //    var message = "This text will be super duper extremely long and unnecessary";
        //    var summary = Test2(message, 25);
        //    Console.WriteLine(summary);
        //Twitter();
            UsingStringBuilder();
        }

        static void Test1()
        {


            var fullname = "Yanmife Ayeni";

            var names = fullname.Split(" ");
            Console.WriteLine("Firstname: {0}", names[0]);
            Console.WriteLine("Lastname: {0}", names[1]);

            Console.WriteLine("Replaced Name: " + fullname.Replace("Yanmife", "Jide"));
            Console.WriteLine("Upper case Name: " + fullname.Replace("Yanmife", "Jide").ToUpper());

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            Console.Write("Enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age: " + age);

            float price = 15.68f;
            Console.WriteLine("the price of bread is " + price.ToString("C"));
            Console.WriteLine("the approximated price of bread is " + price.ToString("C0"));
            Console.WriteLine("the approximated price of bread to 1DP is " + price.ToString("C1"));
        }

        static string Test2(string Input, int maxlength=20)
        {
            if (Input.Length < maxlength)
            {
                return Input;
            }
            else
            {
                var Words=Input.Split(" ");
                var Individuals = new List<string>();
                var TotalCharacters=0;
                
                    foreach(var item in Words)
                    {
                        Individuals.Add(item);
                        TotalCharacters += item.Length + 1;

                        if (TotalCharacters > maxlength)
                            break;
                    }
                var summary = string.Join(" ", Individuals)+"....";
                return("Sentence: "+summary);
            }
            
        }
        static void Twitter()
        {
            var sentence = "Brand fortification: remember our brand is precious – we need to defend, as well as build our brand. As we build the brand, as consumers, policy makers and other stakeholders recognize the brand, remember the weakest link can break our brand";

            const int maxLength = 128;

            if (sentence.Length <= maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var separated = sentence.Split(" ");
                var summarizedList = new List<string>();
                var characters = 0;

                foreach (var word in separated)
                {
                    summarizedList.Add(word);
                    characters += word.Length + 1;

                    if (characters > maxLength)
                    {
                        break;
                    }
                }

                var summary = string.Join(" ", summarizedList);
                Console.WriteLine("Conversion: " + summary + "...");
            }
        }
        static void UsingStringBuilder()
        {
            var Name=new StringBuilder();
            Name.Append("Yanmife")
                .Append(" Ayeni")
                .AppendLine()
                .Append('-', 10)
                .AppendLine()
                .Insert(0, "Oluwa");
            Console.WriteLine(Name);

            var OldName=new StringBuilder(Name.ToString().Substring(0,12));
            var NewName = new StringBuilder("OLUWAYANMIFE");

            Name.Replace('Y', 'y')
            .Append('+', 20)
            .Remove(17,10);

            Console.WriteLine(Name);

        }


    }
}
