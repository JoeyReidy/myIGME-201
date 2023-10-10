using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SUV car = new SUV();
            AddPassenger(car);
        }

        public static void AddPassenger(IPassengerCarrier vehicle)
        {
            vehicle.LoadPassenger();
            Console.WriteLine(vehicle.ToString());

        }
    }
}
