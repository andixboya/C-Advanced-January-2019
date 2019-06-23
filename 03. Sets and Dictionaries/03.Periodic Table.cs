using System;
using System.Collections.Generic;
using System.Linq;

namespace TestLab
{
    class StartUp
    {
        static void Main(string[] args)
        {

            HashSet<string> chemicalCompounds = new HashSet<string> { };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] partitions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < partitions.Length; j++)
                {

                    string current = partitions[j];

                    chemicalCompounds.Add(current);

                }

            }

            Console.WriteLine(string.Join(" ",chemicalCompounds.OrderBy(c=> c)));

        }
    }
}
