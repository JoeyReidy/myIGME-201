using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();
            friendBirthdays.Add("Eli", new DateTime(2004, 5, 15));
            friendBirthdays.Add("Anthony", new DateTime(2003, 3, 22));
            friendBirthdays.Add("Matt", new DateTime(2003, 7, 10));

            foreach (var friend in friendBirthdays)
            {
                Console.WriteLine(friend.Key + ": " + friend.Value.ToString("MM/dd/yyyy"));
            }


        }
    }
}
