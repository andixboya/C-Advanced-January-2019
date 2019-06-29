using System;
using System.Linq;
using System.Text;

namespace Froggy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int[] numbersToAdd = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var lake = new Lake(numbersToAdd);

            PrintResults(lake);

        }

        private static void PrintResults(Lake lake)
        {
            StringBuilder sb = new StringBuilder();

            int counter = 0;
            foreach (var item in lake)
            {
                if (counter == lake.Numbers.Count - 1)
                {
                    sb.Append(item);
                }
                else
                {
                    sb.Append($"{item}, ");
                    counter++;
                }

            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
