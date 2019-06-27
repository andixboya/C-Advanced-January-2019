using System;
using System.Linq;

namespace P01Box
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();

                box.AddValue(current);
            }


            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            box.SwapElements(firstIndex, secondIndex);

            Console.WriteLine(box);



        }
    }
}
