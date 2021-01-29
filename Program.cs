/*
Author: Cody Jones
Date: 1/28/2021
Comments: This C# application demonstrates conditional statements after
          input from users.
*/

using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for input
            Console.WriteLine("What grade do you expect to get in ISM 4300? Enter an integer value");
            try
            {
                // Validating user input
                string input = Console.ReadLine();
                // This variable will be used to store grade after input is parsed to integer value.
                int grade = int.Parse(input);
                // These IF/ELSE statements will test users input for display of letter grade
                if (grade >= 98)
                {
                    Console.WriteLine("A+");
                }
                else if (grade >= 92 && grade <= 97)
                {
                    Console.WriteLine("A");
                }
                else if (grade >= 90 && grade <= 91)
                {
                    Console.WriteLine("A-");
                }
                else if (grade >= 88 && grade <= 89)
                {
                    Console.WriteLine("B+");
                }
                else if (grade >= 82 && grade <= 87)
                {
                    Console.WriteLine("B");
                }
                else if (grade >= 80 && grade <= 81)
                {
                    Console.WriteLine("B-");
                }
                else if (grade >= 78 && grade <= 79)
                {
                    Console.WriteLine("C+");
                }
                else if (grade >= 72 && grade <= 77)
                {
                    Console.WriteLine("C");
                }
                else if (grade >= 70 && grade <= 71)
                {
                    Console.WriteLine("C-");
                }
                else if (grade >= 68 && grade <= 69)
                {
                    Console.WriteLine("D+");
                }
                else if (grade >= 62 && grade <= 67)
                {
                    Console.WriteLine("D");
                }
                else if (grade >= 60 && grade <= 61)
                {
                    Console.WriteLine("D-");
                }
                else if (grade < 60)
                { 
                    Console.WriteLine("F");
                }
            } // end of try
            catch
            {
                Console.WriteLine("Please use a integer data type for your grade next time");
            } // End of catch
        } // End of Main
    } // End of class
} // End of namespace
