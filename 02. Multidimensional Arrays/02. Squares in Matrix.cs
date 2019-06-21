using System;
using System.Linq;

namespace P02SquaresInMatrix
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowMax = size[0];
            int colMax = size[1];

            var matrix= FillInMatrix(rowMax);

            int count= GetCountOfSimilarCharSquares(matrix,colMax);

            Console.WriteLine(count);

        }

        private static int GetCountOfSimilarCharSquares(char[][] matrix, int colMax)
        {
            int rowMax = matrix.GetLength(0);
            


            int count = 0;

            for (int row = 0; row < rowMax-1; row++)
            {
                for (int col = 0; col < colMax-1; col++)
                {

                    if (matrix[row][col]==matrix[row][col +1] &&
                        matrix[row][col]== matrix[row+1][col] &&
                        matrix[row][col]== matrix[row+1][col +1])
                    {
                        count++;
                    }

                }

            }

            return count;

        }

        private static char[][] FillInMatrix(int rowMax)
        {
            char[][] matrix = new char[rowMax][];

            for (int row = 0; row < rowMax; row++)
            {

                char[] inputRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                matrix[row] = inputRow;

            }

            return matrix;
        }
    }
}
