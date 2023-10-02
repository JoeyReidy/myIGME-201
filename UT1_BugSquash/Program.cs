using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            // int nY   compile error
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.);    compile error
            Console.WriteLine("This program calculates x ^ y.");
            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine();   logical error
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
                //} while (int.TryParse(sNumber, out nX));  compile error and run-timer error
            } while (!int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            //Console.WriteLine("{nX}^{nY} = {nAnswer}");   Compile error
            Console.WriteLine(nX + "^" + nY + " = " + nAnswer);
        }


        //int Power(int nBase, int nExponent)   compile error
        private static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //returnVal = 0;    compile error
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1);    run-time error
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal;    compile error
            return returnVal;
        }
    }
}
