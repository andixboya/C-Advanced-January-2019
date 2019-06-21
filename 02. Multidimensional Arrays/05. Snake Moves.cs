using System;
using System.Collections.Generic;
using System.Linq;

namespace P05SnakeMoves
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowMax = size[0];
            int colMax = size[1];

            char[][] matrix = new char[rowMax][];

            char[] symbols = Console.ReadLine().ToCharArray();
            Queue<char> symbolsAsChars = new Queue<char>(symbols);

            for (int row = 0; row < rowMax; row++)
            {
                matrix[row] = new char[colMax];

                for (int col = 0; col < colMax; col++)
                {
                    var current = symbolsAsChars.Dequeue();
                    matrix[row][col] = current;

                    symbolsAsChars.Enqueue(current);
                }

                //matrix[row] = ;
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("",row));
            }


        }
    }
}
