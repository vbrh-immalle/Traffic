using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    abstract class Dealership
    {
        public Dealership()
        {
            Console.WriteLine("A new dealership has been constructed. You can now buy vehicles here!");
        }

        abstract public Vehicle BuyVehicle();
        abstract public Vehicle BuyVehicle(string description);
    }
}
