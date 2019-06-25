using System;
using System.Linq;

namespace P07PredicateForNames
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            words = words.Where(x => FilterByLength(x, n)).ToArray();

            Print(words);

        }

        public static Func<string, int, bool> FilterByLength = (x, y) => x.Length <= y;
        public static Action<string[]> Print = x => Console.WriteLine(string.Join("\n", x));
    }
}
