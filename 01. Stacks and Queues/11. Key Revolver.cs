using System;
using System.Collections.Generic;
using System.Linq;

namespace P11KeyRevolver
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int priceOfEachBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] locks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int valueOfIntelligence = int.Parse(Console.ReadLine());

            // front to back
            Queue<int> locksAsQueue = new Queue<int>(locks);
            Stack<int> bulletsAsStack = new Stack<int>(bullets);


            int bulletCount = 0;

            while (locksAsQueue.Count > 0 && bulletsAsStack.Count > 0)
            {

                int currentLock = locksAsQueue.Peek();

                int currentBullet = bulletsAsStack.Pop();


                bulletCount++;

                if (currentBullet <= currentLock)
                {
                    locksAsQueue.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (bulletCount % sizeOfGunBarrel == 0 && bulletsAsStack.Count != 0)
                {
                    Console.WriteLine("Reloading!");
                }


            }

            int prizeEarned = valueOfIntelligence - bulletCount * priceOfEachBullet;

            if (locksAsQueue.Count == 0 && bulletsAsStack.Count >= 0)
            {
                Console.WriteLine("{0} bullets left. Earned ${1}",
                    bulletsAsStack.Count
                    , prizeEarned);
            }

            else if (bulletsAsStack.Count == 0 && locksAsQueue.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksAsQueue.Count}");
            }

        }
    }
}
