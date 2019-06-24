using System;
using System.Collections.Generic;
using System.Linq;

namespace TestLab
{
    class StartUp
    {
        static void Main(string[] args)
        {


            char[] input = Console.ReadLine().ToCharArray();


            Dictionary<char, int> charToCount = new Dictionary<char, int> { };

            foreach (var c in input)
            {
                if (!charToCount.ContainsKey(c))
                {
                    charToCount.Add(c, 1);
                }
                else
                {
                    charToCount[c]++;
                }

            }


            foreach (var character in charToCount.OrderBy(c=> c.Key))
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }

        }
    }
}
