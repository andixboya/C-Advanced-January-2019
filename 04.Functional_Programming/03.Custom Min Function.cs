using System;
using System.Linq;

namespace P01ActionPoint
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int result = ReturnSmallest(numbers);

            Console.WriteLine(result);

        }

        public static Func<int[],int> ReturnSmallest = arr =>
        {
            arr= arr.OrderBy(n => n).ToArray();

            return arr.Min();

        };

    }
}
