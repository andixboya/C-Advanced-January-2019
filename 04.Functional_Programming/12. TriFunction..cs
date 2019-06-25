using System;

namespace P013TryFunction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            string[] names = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in names)
            {
                int currentSum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    char current = name[i];
                    currentSum += current;

                    if (currentSum>=num)
                    {
                        Console.WriteLine(name);
                        return;
                    }

                }

            }

        }
    }
}
