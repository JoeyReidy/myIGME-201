using System;
using System.Timers;

namespace _3questions
{
    internal class Program
    {
        static Timer timeOutTimer;
        static bool timeOver = false;
        static string curAns;
        static void Main(string[] args)
        {
            int questionNum;
            string question1 = "What is your favorite color?";
            string question2 = "What is the answer to life, the universe and everything?";
            string question3 = "What is the airspeed velocity of an unladen swallow?";
            string ans1 = "black";
            string ans2 = "42";
            string ans3 = "What do you mean? African or European swallow?";

            string curQuestion;
            string userAns = "";

            bool bValid;
            string repeat;

            while (true)
            {
                questionNum = 0;
                while ((questionNum < 1) | (questionNum > 3))
                {
                    try
                    {
                        Console.Write("Choose your question(1 - 3): ");
                        questionNum = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        continue;
                    }
                }
                if (questionNum == 1) {
                    curQuestion = question1;
                    curAns = ans1;
                }
                else if (questionNum == 2)
                {
                    curQuestion = question2;
                    curAns = ans2;
                }
                else
                {
                    curQuestion = question3;
                    curAns= ans3;
                }

                do
                {
                    timeOutTimer = new Timer(5000);
                    timeOutTimer.Elapsed += new ElapsedEventHandler(TimeUp);
                    timeOver = false;
                    bValid = false;
                    timeOutTimer.Start();

                    Console.WriteLine("You have 5 seconds to answer the following question:");
                    Console.WriteLine(curQuestion);
                    try
                    {
                        userAns = Console.ReadLine();
                        bValid = true;
                        timeOutTimer.Stop();
                    }
                    catch
                    {
                        bValid = false;
                    }
                } while (!timeOver && !bValid);

                if (timeOver)
                {
                    
                }
                else if(userAns == curAns)
                {
                    Console.WriteLine("Well Done!");
                }
                else
                {
                    Console.WriteLine("Wrong!   The anwser is:" + curAns);
                }

                Console.WriteLine("Play again?");
                repeat = Console.ReadLine();
                if (!repeat.ToLower().StartsWith("y"))
                {
                    break;
                }
            }
        }
        static void TimeUp(object sender, EventArgs e)
        {
            Console.WriteLine("Time's up!");
            Console.WriteLine("The anwser is: " + curAns);
            Console.WriteLine("Please press enter");
            timeOver = true;
            timeOutTimer.Stop();
        }
    }
}
