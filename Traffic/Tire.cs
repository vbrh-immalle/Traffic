using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    class Tire
    {
        private double amountOfKilometersRolled = 0.0;
        private double damagePercentage = 0.0;

        public void Roll(double amountOfKilometers)
        {
            amountOfKilometersRolled += amountOfKilometers;
        }

        public void TakeDamage(double percentage)
        {
            damagePercentage += percentage;
        }

        public override string ToString()
        {
            return "Amount of kilometers rolled: " + amountOfKilometersRolled;
        }

        public double AmountOfKilometersRolled
        {
            get
            {
                return amountOfKilometersRolled;
            }
        }
    }
}
