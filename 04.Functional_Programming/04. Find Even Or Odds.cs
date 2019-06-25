using System;
using System.Linq;
using System.Text;

namespace P04.FindEvensOdds
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string condition = Console.ReadLine().ToLower();


            Predicate<int> NumberPredicate = GetNumberPredicate(condition);

            int minNum = Math.Min(nums[0], nums[1]);
            int maxNum = Math.Max(nums[0], nums[1]);

            

            for (int i = minNum; i <= maxNum; i++)
            {
                if (NumberPredicate(Math.Abs(i)))
                {
                    Console.Write(i+" ");
                }
            }

            Console.WriteLine();

            

        }


        public static Predicate<int> GetNumberPredicate(string condition)
        {
            if (condition=="odd")
            {
                return x => x % 2 == 1;
            }
            else
            {
                return x => x % 2 == 0;
            }
        }


    }
}
