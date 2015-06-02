using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardealer = new CarDealership();
            var service = new ServiceGarage();
            var car1 = cardealer.BuyVehicle("Peter's family car");
            var car2 = cardealer.BuyVehicle("Emily's car");
            
            car1.Drive(89.34);
            car1.Drive(10.23);
            car2.Drive(23.2);

            // Emily's car is being sold to Anna
            car2.Description = "Anna's car";
            service.CheckTires(car2);

            car2.Drive(20);

            car2.Drive(2232);

            service.ReplaceTires(car2);

            service.CheckTires(car2);

            var bikedealer = new BikeDealership();
            var bike1 = bikedealer.BuyVehicle("John's bike");

            bike1.Drive(12.3);
            service.CheckTires(bike1);

        }
    }
}
