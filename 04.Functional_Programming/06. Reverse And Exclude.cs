using System;
using System.Linq;

namespace P06ReverseAndExclude
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int conditionNum = int.Parse(Console.ReadLine());

            numbers = numbers.Where(n => FilterByNumber(n, conditionNum)).ToArray();
            ReverseArray(numbers);
            PrintArray(numbers);
         
        }

        public static Func<int, int, bool> FilterByNumber = (x, y) => x % y != 0;
        public static Action<int[]> ReverseArray = x => Array.Reverse(x);
        public static Action<int[]> PrintArray = x => Console.WriteLine(string.Join(" ",x));
    }
}
