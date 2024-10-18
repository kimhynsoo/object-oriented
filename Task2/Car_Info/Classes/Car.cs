using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Info.Classes
{
    public class Car
    {
        public string Model {get; set;}
        public int Year {get; set;}
        public double StartKm {get; set;}
        public double EndKm {get; set;}
        public double FuelConsumption {get; set;}
        public double TravelTime {get; set;}


        public double GetTripLength()
        {
            return (double)(EndKm - StartKm);
        }

        public double GetSpeed()
        {
            return (double)(GetTripLength() / TravelTime);
        }

        public double GetFuelEfficiency()
        {
            return (double)(GetTripLength()/(FuelConsumption/100));
        }

        public void ClassifyCar()
        {
            if (2024 - Year <=1)
            {
                Console.WriteLine("New car,enjoy it!");
            }
            else if (2024 - Year > 1 && 2024 - Year <= 3)
            {
                Console.WriteLine("Semi-used car, how is it going?");
            }
            else if (2024 - Year > 3 && 2024 - Year <= 5)
            {
                Console.WriteLine("Used car, it's probably a good time to start looking for a new one.");
            }
            else
            {
                Console.WriteLine("Old car, please change it!");
            }
            
        }
    }
}