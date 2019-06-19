using System;
using System.Collections.Generic;
using System.Linq;

namespace P05FashionBotique
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacityOfRack = int.Parse(Console.ReadLine());

            Stack<int> clothesAsStack = new Stack<int>(clothes);

            int currentRackCapacity = 0;

            int countOfRacks= 0;

            while (clothesAsStack.Count>0)
            {

                int currentCloth = clothesAsStack.Pop();

                if (currentRackCapacity+currentCloth<capacityOfRack)
                {
                    currentRackCapacity += currentCloth;
                }
                else if (currentRackCapacity+currentCloth==capacityOfRack)
                {
                    currentRackCapacity = 0;
                    countOfRacks++;
                }
                else
                {
                    currentRackCapacity = currentCloth;
                    countOfRacks++;
                }


            }

            if (currentRackCapacity!=0)
            {
                countOfRacks++;
            }

            Console.WriteLine(countOfRacks);
        }
    }
}
