using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    class CarDealership : Dealership
    {
        override public Vehicle BuyVehicle()
        {
            return new Car("A brand new car");
        }

        public override Vehicle BuyVehicle(string description)
        {
            return new Car(description);
        }
    }
}
