/*
    Author: Kayla Worrell
    Date: 01/24/2023
    Description: C# Console Application to calculate letter grades
*/

using System;

namespace Deliverable2_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");

            try
            {
                int grade = int.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your letter grade is " + letter + ".");
                }

                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your letter grade is " + letter + ".");
                }

                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your letter grade is " + letter + ".");
                }

                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your letter grade is " + letter + ".");
                }

                else if (grade < 60)
                {
                    letter = "F";
                    Console.WriteLine("Your letter grade is " + letter + ".");
                }

            }
            catch
            {
                Console.WriteLine("Enter a numeric value.");
            }
        }
    }
}
