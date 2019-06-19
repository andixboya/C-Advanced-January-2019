namespace PoisonousPlants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int> { };

            for (int i = 0; i < n; i++)
            {
                string[] partitions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string command = partitions[0];

                switch (command)
                {
                    case "1":
                        int elementToPush = int.Parse(partitions[1]);
                        numbers.Push(elementToPush);
                        break;

                    case "2":

                        if (numbers.TryPeek(out int result))
                        {
                            numbers.Pop();
                        }
                           
                        break;

                    
                    case "3":
                        if (numbers.Count!=0)
                        {
                            int maxValue = numbers.OrderBy(y => y).LastOrDefault();
                            Console.WriteLine(maxValue);
                        }
                        
                        break;

                    case "4":
                        if (numbers.Count!=0)
                        {
                            int minValue = numbers.OrderBy(u => u).FirstOrDefault();
                            Console.WriteLine(minValue);
                        }

                        break;

                }

            }

            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}