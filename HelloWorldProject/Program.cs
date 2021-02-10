using System;

namespace HelloWorldProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World in C#!");

            // simple console.writeline example
            Console.WriteLine("Written by Jada Doud");


            // defining a variable and how it could be manipulated
            var counter = 0;
            Console.WriteLine(counter);
            counter = counter+13;
            Console.WriteLine(counter);
            counter = counter - 3;
            Console.WriteLine(counter);
            counter = counter*5;
            Console.WriteLine(counter);
            counter = counter/7;
            Console.WriteLine(counter);

            decimal numerator = 10;
            decimal denominator = 3;
            Console.WriteLine(numerator/denominator);

            var firstname = "Jada";
            var lastname = "Doud";
            //Console.WriteLine(firstname + " " + lastname);
            var fullname = firstname + " " + lastname;
            var fullName = $"First Name:{firstname} Last Name:{lastname}";
            fullname = fullname.ToUpper();
            Console.WriteLine(fullname);
            Console.WriteLine(fullName);

            {
                // demonstrating how scope works
                var scopeVariable = 1;
                Console.WriteLine(scopeVariable);
            }
            // Types


            int? nullableInteger = null;
            // int nonNullableInteger = null;

            bool oneEqualsOne = (1 == 1);
            bool thisIsFalse = !oneEqualsOne;

            int[] assessmentScores = new int[2];
            assessmentScores[0] = 120 ;
            assessmentScores[1]=95;
            Console.WriteLine($"Index 0 = {assessmentScores[0]} Index 1 = {assessmentScores[1]}");

            var Topics = new string[5];
            Topics[0] = "GitHub";
            Topics[1] = "Sql";
            Topics[2] = "C#";
            Topics[3] = "JavaScript";
            Topics[4] = "Angular";
        }
    }
}
