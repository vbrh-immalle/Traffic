using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    class ServiceGarage
    {
        private List<Tire> secondHandTires = new List<Tire>();
        private List<Tire> newTires = new List<Tire>();

        public ServiceGarage()
        {
            Console.WriteLine("A new service garage has been constructed. You can replace tires here.");

            for (var i = 0; i < 20; i++)
            {
                newTires.Add(new Tire());
            }
            
            Console.WriteLine("   They have old and new tires here. They start with 20 new tires.");
        }

        public void CheckTires(Vehicle vehicle)
        {
            Console.WriteLine("{0} is being checked in the service garage.", vehicle.Description);
            int nr = vehicle.NrOfTires;

            for(var i=0; i<nr; i++)
            {
                Tire t = vehicle.GetTireInfo(i);
                Console.WriteLine("  tire {0}: {1} km", i, t.AmountOfKilometersRolled);
            }
        }

        public void ReplaceTires(Vehicle vehicle)
        {
            for (var i = 0; i < vehicle.NrOfTires; i++)
            {
                ReplaceOneTire(vehicle, i);
            }
        }

        private void ReplaceOneTire(Vehicle vehicle, int tireNumber)
        {
            Tire newTire;
            Tire oldTire;

            if (newTires.Count > 0)
            {
                newTire = newTires[0]; // take the first tire from the stack of new tires
            }
            else
            {
                Console.WriteLine("Couldn't replace tire. The dealer is out of new tires!");
                return;
            }

            oldTire = vehicle.ReplaceTire(tireNumber, newTire);
            secondHandTires.Add(oldTire);

            Console.WriteLine("Replaced tire {0} (with {1} kilometer) with a new tire.", tireNumber, oldTire.AmountOfKilometersRolled);
        }
    }
}
