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

            Dictionary<string, Dictionary<string, int>> colorToClothes = new Dictionary<string, Dictionary<string, int>> { };

            for (int i = 0; i < n; i++)
            {
                string[] partitions = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = partitions[0];
                string items = partitions.Skip(1).Last();
                string[] itemsAsArr = items.Split(",",StringSplitOptions.RemoveEmptyEntries).ToArray();


                if (!colorToClothes.ContainsKey(color))
                {
                    colorToClothes.Add(color, new Dictionary<string, int> { });
                }

                foreach (var item in itemsAsArr)
                {
                    if (!colorToClothes[color].ContainsKey(item))
                    {
                        colorToClothes[color].Add(item, 1);
                    }
                    else
                    {
                        colorToClothes[color][item]++;
                    }

                }

            }


            string[] partitionsTwo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string wantedColor = partitionsTwo[0];
            string wantedCloth = partitionsTwo[1];

            PrintResult(colorToClothes, wantedColor, wantedCloth);

        }

        private static void PrintResult(Dictionary<string, Dictionary<string, int>> colorToClothes, string wantedColor, string wantedCloth)
        {
            foreach (var kvp in colorToClothes)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var kvpTwo in kvp.Value)
                {

                    if (wantedColor == kvp.Key && wantedCloth == kvpTwo.Key)
                    {
                        Console.WriteLine($"* {kvpTwo.Key} - {kvpTwo.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {kvpTwo.Key} - {kvpTwo.Value}");
                    }


                }

            }
        }
    }
}
