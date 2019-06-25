using System;
using System.Collections.Generic;
using System.Linq;

namespace P09ListOfPredicates
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isDivisible = true;

            List<int> answers = new List<int> { };

            for (int i = 1; i <= n; i++)
            {

                foreach (var num in numbers)
                {
                    if (!PredicateByNumber(i,num))
                    {
                        isDivisible = false;
                        break;
                    }


                }

                if (isDivisible==true)
                {
                    answers.Add(i);
                }

                isDivisible = true;

            }

            Console.WriteLine(string.Join(" ",answers));

        }

        public static Func<int, int, bool> PredicateByNumber = (x, y) => x % y == 0;
    }
}
