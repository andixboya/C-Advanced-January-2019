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

            Box<double> box = new Box<double>();

            List<double> words = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double current = double.Parse(Console.ReadLine());

                words.Add(current);
            }


            double condition = double.Parse(Console.ReadLine());


            int result = box.GreaterThan(words, condition);

            Console.WriteLine(result);


        }
    }
}
