using System;
using System.Linq;

namespace P05AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input!="end")
            {


                if (input=="print")
                {

                    Console.WriteLine(string.Join(" ", numbers)); 
                    
                }
                else
                {
                    Func<int,int> MathFunc = GetMathFunc(input);

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = MathFunc(numbers[i]);
                    }
                }

                input = Console.ReadLine();
            }


        }

        private static Func<int,int> GetMathFunc(string input)
        {

            if (input == "add")
            {

                return x => x+=1;

            }
            
            else if (input == "subtract")
            {
                return x => x -= 1;
            }
            else
            {
                return x => x *= 2;
            }


        }
    }
}
