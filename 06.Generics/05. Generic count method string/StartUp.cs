using System;
using System.Collections.Generic;
using System.Linq;

namespace P01Box
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            List<string> words = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();

                words.Add(current);
            }


            string condition = Console.ReadLine();


            int result = box.GreaterThan(words, condition);

            Console.WriteLine(result);


        }
    }
}
