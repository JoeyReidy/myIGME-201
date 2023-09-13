using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);
            int guess;
            int attempt = 1;

            while (attempt <= 8)
            {
                //get user guess and make sure that it is a vaild guess
                Console.WriteLine("Turn #" + attempt +  ": Guess a number 1 - 100:");
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Invalid");
                    continue;
                }
                if ((guess < 1) || (guess > 100)) {
                    Console.WriteLine("Your guess must be inbetween 1 - 100");
                    continue;
                }
                
                //compare guess to random number
                if(guess == randomNumber)
                {
                    Console.WriteLine("Correct! you won in " + attempt + " turns.");
                    break;
                }
                else if(guess < randomNumber)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Too high");
                }
                attempt++;

            }
            if(attempt > 8) {
                Console.WriteLine("No more turns remaining. The number was " + randomNumber);
            }
        }
    }
}
