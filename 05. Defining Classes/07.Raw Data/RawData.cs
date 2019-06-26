using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car> { };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] partitions = Console.ReadLine().Split();

                string model = partitions[0];
                int engSpeed = int.Parse(partitions[1]);
                int engPower = int.Parse(partitions[2]);
                int cargoWeight = int.Parse(partitions[3]);
                string cargoType = partitions[4];
                double[] tireInfo = partitions.Skip(5).Select(double.Parse).ToArray();// this should... work i think

                Car currentCar = new Car(model, engSpeed, engPower, cargoWeight, cargoType, tireInfo);

                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            if (command=="fragile")
            {
                foreach (var car in cars.
                    Where(x=> x.Cargo.Type=="fragile" 
                    &&  x.Tires.TiresSet.Any(t=> t.Pressure<1)))
                {
                    Console.WriteLine(car.Model);
                }

            }
            else if(command=="flamable")
            {
                foreach (var car in cars.
                   Where(x => x.Cargo.Type == "flamable"
                   && x.Engine.Power>250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
