using System;
using System.Collections.Generic;
using System.Linq;

namespace P08CustomComparator
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray() ;


            nums= SortNumbers(nums);

            Console.WriteLine(string.Join(" ",nums));
            
        }

        public static Func<int[], int[]> SortNumbers = arr =>
         {

             List<int> oddNums = new List<int> { };
             List<int> evenNums = new List<int> { };

             foreach (var num in arr)
             {
                 if (num%2==0)
                 {
                     evenNums.Add(num);
                 }
                 else
                 {
                     oddNums.Add(num);
                 }
             }


             oddNums= oddNums.OrderBy(n => n).ToList();
             evenNums = evenNums.OrderBy(n => n).ToList();

             int[] result = evenNums.Concat(oddNums).ToArray();

             return result;
         };
    }
}
