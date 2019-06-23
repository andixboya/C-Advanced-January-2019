using System;
using System.Collections.Generic;
using System.Linq;

namespace TestLab
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> integerToCount = new Dictionary<int, int> { };

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!integerToCount.ContainsKey(number))
                {
                    integerToCount.Add(number, 1);
                }
                else
                {
                    integerToCount[number]++;
                }
                 

            }


            foreach (var item in integerToCount.Where(x=> x.Value%2==0))
            {
                Console.WriteLine(item.Key);
            }

        }
    }
}
