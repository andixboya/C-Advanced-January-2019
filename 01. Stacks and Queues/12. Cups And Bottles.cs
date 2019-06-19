using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P12CupsAndBottles
{
    public class Program
    {
        

        public static void Main(string[] args)
        {

            int[] cups = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bottles = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //remaining litters
            //wasted water


            Queue<int> cupsAsQueue = new Queue<int>(cups);
            Stack<int> bottlesAsStack = new Stack<int>(bottles);


            //if bottles > 0 print bottles
            //if cups > 0 print... cups (in queue) 


            int littersWasted = 0;

            //bool noBottlesLeft = false;

            while (cupsAsQueue.Count>0 && bottlesAsStack.Count>0)
            {
                
                int currentCup = cupsAsQueue.Peek();


                if (currentCup<=bottlesAsStack.Peek())
                {
                    int currentBottle = bottlesAsStack.Pop();
                    littersWasted += (currentBottle - currentCup);
                    cupsAsQueue.Dequeue();
                }

                // in case we need more than one bottle , to fill up the cup 
                else
                {

                    int accumulatedWater = 0;

                    while (bottlesAsStack.Any() && accumulatedWater<currentCup )
                    {

                        accumulatedWater += bottlesAsStack.Pop();
                        

                    }

                    // in case there is not enough bottles to fill up the cup

                    if (!bottlesAsStack.Any() && currentCup> accumulatedWater)
                    {
                        
                        break;
                    }

                    // in case there is enough water
                    else
                    {
                        littersWasted += (accumulatedWater - currentCup);
                        cupsAsQueue.Dequeue();

                    }

                }

            }


            if (!cupsAsQueue.Any())
            {
                string orderedBottles = OrderBottles(bottlesAsStack);

                Console.WriteLine("Bottles: {0}",
                    orderedBottles);
                Console.WriteLine("Wasted litters of water: {0}",
                    littersWasted);
                // not string... 
            }

            else if (!bottlesAsStack.Any())
            {
                Console.WriteLine("Cups: {0}",
                    string.Join(" ",cupsAsQueue));
                Console.WriteLine("Wasted litters of water: {0}",
                    littersWasted);
            }

        }

        private static string OrderBottles(Stack<int> bottlesAsStack)
        {

            StringBuilder sb = new StringBuilder();

            while (bottlesAsStack.Count>0)
            {
                sb.Append($"{bottlesAsStack.Pop()} ");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
