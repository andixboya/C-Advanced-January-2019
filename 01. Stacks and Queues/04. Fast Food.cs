using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04FastFood
{
    public class FastFood
    {


        public static void Main(string[] args)
        {

            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> ordersAsQueue = new Queue<int>(orders);


            while (ordersAsQueue.Any())
            {

                if (quantityOfFood<=0)
                {
                    break;
                }

                int currentOrder = ordersAsQueue.Peek();

                if (currentOrder > quantityOfFood)
                {
                    
                    break;
                }
                else
                {
                    
                    quantityOfFood -= currentOrder;
                    ordersAsQueue.Dequeue();
                }

            }

            Console.WriteLine(orders.Max());

            if (!ordersAsQueue.Any())
            {
                Console.WriteLine("Orders complete");
            }

            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", ordersAsQueue)}");
            }

        }

    }
}
