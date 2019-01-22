/*
Author: Jared Hanlon
Date: 1/21/2019
Comments: This C# Console application code demonstrates the use of 
          conditional statements after getting input from users
*/

using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to receive in ISM 4300?");
            
            /* use the try catch block to validate user input
               if the user provides bad input, the catch block
               will display a message and recommend proper input
            */

            try
            {
                string input = Console.ReadLine();

                int grade = int.Parse(input);

                // if / if else / else statement 
                if ((grade > 97) && (grade < 101))
                {
                    Console.WriteLine("Your grade for ISM 4300 is an A+");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else if ((grade > 91) && (grade < 98))
                {
                    Console.WriteLine("Your grade for ISM 4300 is an A");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else if ((grade > 89) && (grade < 92))
                {
                    Console.WriteLine("Your grade for ISM 4300 is an A-");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else if ((grade > 87) && (grade < 90))
                {
                    Console.WriteLine("Your grade for ISM 4300 is a B+");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else if ((grade > 81) && (grade < 88))
                {
                    Console.WriteLine("Your grade for ISM 4300 is a B");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else if ((grade > 79) && (grade < 82))
                {
                    Console.WriteLine("Your grade for ISM 4300 is a B-");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else if ((grade > 77) && (grade < 80))
                {
                    Console.WriteLine("Your grade for ISM 4300 is a C+");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else if ((grade > 71) && (grade < 78))
                {
                    Console.WriteLine("Your grade for ISM 4300 is a C");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else if ((grade > 69) && (grade < 72))
                {
                    Console.WriteLine("Your grade for ISM 4300 is a C-");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else if ((grade > 67) && (grade < 70))
                {
                    Console.WriteLine("Your grade for ISM 4300 is a D+");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else if ((grade > 61) && (grade < 68))
                {
                    Console.WriteLine("Your grade for ISM 4300 is a D");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else if ((grade > 59) && (grade < 62))
                {
                    Console.WriteLine("Your grade for ISM 4300 is a D-");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else if (grade < 60)
                {
                    Console.WriteLine("Your grade for ISM 4300 is an F ");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
            } // end of try
            catch
                {
                Console.WriteLine("Please use an integer data type between 0 and 101 for your expected grade next time");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
                } // end of catch

        } // end of main
    } // end of class
} // end of namespace
