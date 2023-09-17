using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace madLibs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string finalStory = "";
            string name = "";
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;
            StreamReader input;

            /*get madLibs from file*/
            input = new StreamReader("../../../templates/MadLibsTemplate.txt");

            string line = null;
            while((line = input.ReadLine()) != null) {
                ++numLibs;
            }
            input.Close();

            string[] madLibs = new string[numLibs];

            input = new StreamReader("../../../templates/MadLibsTemplate.txt");
            line = null;
            while ((line = input.ReadLine()) != null)
            {
                madLibs[cntr] = line;
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");
                cntr++;
            }
            input.Close();

            /*start prompting user for things*/

            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();

            Console.WriteLine("Welcome, " + name + ". would you like to play madLibs?");
            string yesNo = Console.ReadLine();
            while((yesNo.ToLower() != "yes") && (yesNo.ToLower() != "no"))
            {
                Console.WriteLine("you must make a choice. yes or no?");
                yesNo = Console.ReadLine();
            }
            while((yesNo.ToLower() == "yes"))
            {
                Console.WriteLine("choose a madlib to play(1-6):");

                while ((nChoice < 1) || (nChoice > 6))
                {
                    nChoice = Convert.ToInt32(Console.ReadLine());
                }
                nChoice--;

                string[] words = madLibs[nChoice].Split(' ');
                foreach (string word in words)
                {
                    if (word[0] == '{')
                    {
                        string replaceWord = word.Replace("{", "").Replace("}", "").Replace("_", "");
                        Console.Write("Input a " + replaceWord + ": ");
                        finalStory += Console.ReadLine() + " ";
                    }
                    else
                    {
                        finalStory += word + " ";
                    }
                }
                Console.WriteLine("Your madlib is complete!");
                Console.WriteLine(finalStory);

                Console.WriteLine("would you like to play again?");
                yesNo = Console.ReadLine();
            }
            Console.WriteLine("goodbye!");
            
        }
    }
}
