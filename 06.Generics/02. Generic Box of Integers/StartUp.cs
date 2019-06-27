using System;

namespace P01Box
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                var box = new Box<int>(current);

                Console.WriteLine(box);

            }


        }
    }
}
