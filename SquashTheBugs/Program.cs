using System;

namespace SquashTheBugs
{

    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            //syntax error, missing ;
            int i = 0;
            string allNumbers = null;
            // loop through the numbers 1 through 10
            for (i = 1; i < 10; ++i)
            {
                // declare string to hold all numbers
                //string allNumbers = null;
                //syntax error, allNumbers needs to be declared outside of for loop in order to be called later

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                //syntax error, needs () to subtract 1 from i
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                //Console.WriteLine(i / (i - 1));
                //run-time error, tries to divide by zero
                if(i == 1)
                {
                    Console.WriteLine("undefined");
                }
                else
                {
                    Console.WriteLine(i / (i - 1));
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i = i + 1;
                //logical error, i increments by itself after each loop
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            //syntax error, missing +
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}
