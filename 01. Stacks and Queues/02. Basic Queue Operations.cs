using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.ExerciseQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            // endqueue (add) elements
            // dequeue (remove) elements
            // elementToSearchFor 
            //if true , print true  ; 
            //else smallest int current queue, 
            //when there are none 0 

            int[] commandWithNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementsToAdd = commandWithNums[0];
            int elementsToRemove = commandWithNums[1];
            int wantedElement = commandWithNums[2];

            int[] numbersToAdd = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbersInQueue = new Queue<int>(100);

            for (int i = 0; i < numbersToAdd.Length; i++)
            {

                int currentNumberToAdd = numbersToAdd[i];

                numbersInQueue.Enqueue(currentNumberToAdd);

            }

            for (int i = 0; i < elementsToRemove; i++)
            {

                if (numbersInQueue.Count==0)
                {
                    break;
                }

                numbersInQueue.Dequeue();

            }

            if (!numbersInQueue.Contains(wantedElement))
            {
                if (numbersInQueue.Count==0)
                {
                    Console.WriteLine(0);
                    return;
                }

                var answer = numbersInQueue
                    .OrderByDescending(x => x)
                    .Last();

                Console.WriteLine(answer);

            }

            else
            {

                Console.WriteLine("true");
            }

        }
    }
}
