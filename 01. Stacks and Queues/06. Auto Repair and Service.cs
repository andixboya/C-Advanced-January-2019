using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P06AutoRepairAndService
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string[] cars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> waitingCars = new Queue<string>(cars);

            Stack<string> servedCars = new Stack<string> { };


            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Service")
                {

                    //TODO validation in  case there are no cars to be served

                    if (waitingCars.Count>0)
                    {
                        string servedCar = waitingCars.Dequeue();
                        servedCars.Push(servedCar);

                        Console.WriteLine("Vehicle {0} got served.",
                            servedCar);
                    }
                }

                // in case of history
                else if (input == "History")
                {
                    Console.WriteLine(string.Join(", ",servedCars));
                }

                else
                {
                    string[] partitions = input.Split("-");

                    string carName = partitions[1];

                    if (waitingCars.Contains(carName))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }

                }

                input = Console.ReadLine();

            }

            PrintAllCars(servedCars, waitingCars);
        }

        private static void PrintAllCars(Stack<string> servedCars, Queue<string> waitingCars)
        {

            if (waitingCars.Count>0)
            {
                Console.WriteLine("Vehicles for service: {0}",
                string.Join(", ", waitingCars));
            }
            
            Console.WriteLine("Served vehicles: {0}",
                string.Join(", ", servedCars));

            
        }
    }
}
