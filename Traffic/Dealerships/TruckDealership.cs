using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    class TruckDealership : Dealership
    {
        public override Vehicle BuyVehicle()
        {
            return new Truck("A brand new truck");
        }
        
        override public Vehicle BuyVehicle(string description)
        {
            return new Truck(description);
        }
    }
}
