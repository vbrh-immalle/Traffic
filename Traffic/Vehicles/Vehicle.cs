using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    class Vehicle
    {
        public string Description { get; set; }
        protected List<Tire> tires = new List<Tire>();

        public Vehicle(int nrOfTires, string description)
        {
            CreateTires(nrOfTires);
            Description = description;

            Console.WriteLine("{0} has been created. It has {1} tires!", Description, tires.Count);
        }

        private void CreateTires(int nrOfTires)
        {
            for (var i = 0; i < nrOfTires; i++)
            {
                tires.Add(new Tire());
            }
        }

        virtual public void Drive(double amountOfKilometer)
        {
            Console.WriteLine("{0} (with {1} tires) drives {2} kilometer.", Description, tires.Count, amountOfKilometer);
            foreach(var tire in tires)
            {
                tire.Roll(amountOfKilometer);
            }
        }

        public int NrOfTires
        {
            get
            {
                return tires.Count;
            }
        }

        public Tire GetTireInfo(int tireNumber)
        {
            if (tireNumber > tires.Count)
            {
                Console.WriteLine("That tire number doesn't exist!");
                return null; // this would perhaps be better handled with Exceptions
            }
            else
            {
                return tires[tireNumber];
            }
        }

        public Tire ReplaceTire(int tireNumber, Tire newTire)
        {
            if (tireNumber > tires.Count)
            {
                Console.WriteLine("That tire number doesn't exist!");
                return null; // this would perhaps be better handled with Exceptions
            }
            else
            {
                var oldTire = tires[tireNumber];
                tires[tireNumber] = newTire;
                return oldTire;
            }
        }
    }
}
