using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    class BikeDealership : Dealership
    {
        override public Vehicle BuyVehicle()
        {
            return new Bike("A brand new bike");
        }

        override public Vehicle BuyVehicle(string description)
        {
            return new Bike(description);
        }
    }
}
