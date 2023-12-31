﻿using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            Console.WriteLine("Please enter a starting number:");
            double imagCoordStart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a second, smaller number:");
            double imagCoordEnd = Convert.ToDouble(Console.ReadLine());
            while(imagCoordEnd >= imagCoordStart)
            {
                Console.WriteLine("Try again:");
                imagCoordEnd = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Please enter another starting number:");
            double realCoordStart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a second, larger number:");
            double realCoordEnd = Convert.ToDouble(Console.ReadLine());
            while (realCoordEnd <= realCoordStart)
            {
                Console.WriteLine("Try again:");
                realCoordEnd = Convert.ToDouble(Console.ReadLine());
            }


            for (imagCoord = imagCoordStart; imagCoord >= imagCoordEnd; imagCoord -= (imagCoordStart - imagCoordEnd)/48)
            {
                for (realCoord = realCoordStart; realCoord <= realCoordEnd; realCoord += (realCoordEnd - realCoordStart) / 80)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
