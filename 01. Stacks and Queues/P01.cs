namespace PoisonousPlants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numPush = nums[0];
            int numPop = nums[1];
            int numCriteria = nums[2];

            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int> (integers);

            for (int i = 0; i < numPop; i++)
            {
                if (numbers.Count>0)
                {
                    numbers.Pop();
                }
                
            }

            if (numbers.Contains(numCriteria))
            {
                Console.WriteLine("true");
            }

            else
            {
                int result = numbers.OrderBy(i => i).FirstOrDefault();

                Console.WriteLine(result);
            }


        }
    }
}