using System;
using System.Linq;

namespace P01ActionPoint
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split(" ");

            foreach (var word in words)
            {
                Print(word);
            }


        }

        public static Action<string> Print = input =>
        {
            Console.WriteLine(input);
        };
    }
}
