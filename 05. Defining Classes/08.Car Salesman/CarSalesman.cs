using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class CarSalesman
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Engine> enginesAvailable = new List<Engine> { };
            List<Car> cars = new List<Car> { };

            for (int i = 0; i < n; i++)
            {
                //“< Model > < Power > < Displacement > < Efficiency >”. 
                string[] partitionsEngine = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string model = partitionsEngine[0];
                double power = double.Parse(partitionsEngine[1]);

                Engine engine = new Engine(model, power);

                if (partitionsEngine.Length==3)
                {
                    if (double.TryParse(partitionsEngine[2], out double result))
                    {
                        engine.Displacement = partitionsEngine[2];
                    }
                    else
                    {
                        engine.Efficiency = partitionsEngine[2];
                    }

                }
                else if (partitionsEngine.Length==4)
                {
                    engine.Displacement = partitionsEngine[2];
                    engine.Efficiency = partitionsEngine[3];
                }

                enginesAvailable.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                //“<Model> <Engine> <Weight> <Color>
                string[] partitionsForCar = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = partitionsForCar[0];
                string engineModel = partitionsForCar[1];

                Engine currentEngine = enginesAvailable.FirstOrDefault(e => e.Model == engineModel); // this should be valid ,and the reference should be made like this

                Car car = new Car(currentEngine, model);

                if (partitionsForCar.Length == 3)
                {
                    if (double.TryParse(partitionsForCar[2], out double result))
                    {
                        car.Weight = partitionsForCar[2];

                    }
                    else
                    {
                        car.Color = partitionsForCar[2];
                    }

                }
                else if (partitionsForCar.Length == 4)
                {
                    car.Weight = partitionsForCar[2];
                    car.Color = partitionsForCar[3];
                }
                cars.Add(car);
            }

            foreach (var car in cars)
            {

                //Console.WriteLine("{0}:",
                //    car.Model);
                //Console.WriteLine("  {0}:",
                //    car.Engine.Model);
                //Console.WriteLine("    Power: {0}",
                //    car.Engine.Power);
                //Console.WriteLine("    Displacement: {0}",
                //    car.Engine.Displacement);
                //Console.WriteLine("    Efficiency: {0}",
                //    car.Engine.Efficiency);
                //Console.WriteLine("  Weight: {0}",
                //    car.Weight);
                //Console.WriteLine("  Color: {0}",
                //    car.Color);
                Console.WriteLine($@"{car.Model}:
  {car.Engine.Model}:
    Power: {car.Engine.Power}
    Displacement: {car.Engine.Displacement}
    Efficiency: {car.Engine.Efficiency}
  Weight: {car.Weight}
  Color: {car.Color}");

            }

        }
    }
}
