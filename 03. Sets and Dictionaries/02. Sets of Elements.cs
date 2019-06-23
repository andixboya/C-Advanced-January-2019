using System;
using System.Collections.Generic;
using System.Linq;

namespace TestLab
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            int n = nums[0];
            int m = nums[1];

            HashSet<int> firstNumbers = new HashSet<int> { };
            HashSet<int> secondNumbers = new HashSet<int> { };

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                firstNumbers.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());

                secondNumbers.Add(number);

            }


            HashSet<int> resultNumbers = new HashSet<int> { };

            foreach (var num in firstNumbers)
            {

                if (secondNumbers.Contains(num))
                {
                    resultNumbers.Add(num);
                }

            }

            Console.WriteLine(string.Join(" ",resultNumbers));


        }
    }
}
