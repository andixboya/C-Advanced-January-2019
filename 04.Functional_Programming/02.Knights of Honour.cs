using System;
using System.Linq;

namespace P02KnigtsOfHonour
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                Print(word);
            }


        }

        public static Action<string> Print = input =>
        {
            input = "Sir "+input;

            Console.WriteLine(input);
        };

      
    }
}
