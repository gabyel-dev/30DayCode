using System;

namespace VarDeclaration
{
    class Day2
    {
        static void Main(string[] args)
        {
            /* variable and constant 
             to declare  const data_type constant_name = value */

            int age = 20;
            const string namee = "Gab";
            string[] hobbies = { "Guitar", "Coding" };
            double moneyhave = 100.20;
            bool isTired = true;
            char grade = 'A';

            Console.WriteLine($"Hello! my name is {namee} im {age} and my hobbies are playing {hobbies[0]}, and i also love {hobbies[1]}");
            Console.WriteLine($"The total money i have now is {moneyhave}$ and if u ask me if im tired {isTired} but my Grade is {grade}");
        }
    }
}