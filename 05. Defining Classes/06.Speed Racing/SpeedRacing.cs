using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class SpeedRacing

    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car> { };


            for (int i = 0; i < n; i++)
            {

                string[] partitions = Console.ReadLine().Split();

                string model = partitions[0];
                decimal fuel = decimal.Parse(partitions[1]);
                decimal consumption = decimal.Parse(partitions[2]);

                Car currentCar = new Car
                {
                    ConsumptionPerKm = consumption,
                    Fuel = fuel,
                    Model = model
                };

                cars.Add(currentCar);
            }


            string line = Console.ReadLine();

            while (line!= "End")
            {
                string[] partitions = line.Split();
                string model = partitions[1];
                decimal amountOfKm = decimal.Parse(partitions[2]);

                Car car = cars.Where(x=> x.Model==model).FirstOrDefault();

                if (car.CanMove(amountOfKm))
                {
                    car.Travel(amountOfKm);
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                line = Console.ReadLine();
            }

            foreach (var car in cars)
            {

                Console.WriteLine("{0} {1:f2} {2}",
                    car.Model,
                    car.Fuel,
                    car.TravelDistance);

            }

        }
    }
}
