using System;
using System.Linq;
using System.Text;

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

            int[][] matrix = FillInMatrix(rowMax);

            int[] indexes = GetBiggestSquare(matrix);

            int[,] resultMatrix = new int[3, 3];

            PrintResults(matrix, indexes);

        }

        private static void PrintResults(int[][] matrix, int[] indexes)
        {

            int sum = 0;

            StringBuilder sb = new StringBuilder();

            for (int r = indexes[0]; r < indexes[0] + 3; r++)
            {

                for (int c = indexes[1]; c < indexes[1] + 3; c++)
                {

                    if (c == indexes[1] + 2)
                    {
                        sb.AppendLine($"{matrix[r][c]}");
                    }
                    else
                    {
                        sb.Append($"{matrix[r][c]} ");
                    }

                    sum += matrix[r][c];
                }

            }

            Console.WriteLine("Sum = {0}",
                sum);
            Console.WriteLine(sb.ToString().TrimEnd());
            
        }

        private static int[] GetBiggestSquare(int[][] matrix)
        {

            int rowMax = matrix.GetLength(0);
            int colMax = matrix[0].Length;
            int[] indexes = new int[2];
            int maxSum = 0;

            for (int row = 0; row < rowMax-2; row++)
            {

                for (int col = 0; col < colMax-2; col++)
                {

                    int currentSum= GetSum(row,col, matrix);

                    if (currentSum>maxSum)
                    {
                        maxSum = currentSum;

                        indexes = new int[2] { row, col };
                    }

                }

            }

            return indexes;

        }

        private static int GetSum(int startRow, int startCol, int[][] matrix)
        {
            int sum = 0;

            for (int currentRow = startRow; currentRow < startRow+3; currentRow++)
            {
                for (int currentCol = startCol; currentCol < startCol+3; currentCol++)
                {

                    sum += matrix[currentRow][currentCol];

                }

            }

            return sum;
            

        }

        private static int[][] FillInMatrix(int rowMax)
        {
            int[][] matrix = new int[rowMax][];

            for (int row = 0; row < rowMax; row++)
            {

                int[] inputRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = inputRow;

            }

            return matrix;
        }

        //private static int GetCountOfSimilarCharSquares(char[][] matrix, int colMax)
        //{
        //    int rowMax = matrix.GetLength(0);



        //    int count = 0;

        //    for (int row = 0; row < rowMax-1; row++)
        //    {
        //        for (int col = 0; col < colMax-1; col++)
        //        {

        //            if (matrix[row][col]==matrix[row][col +1] &&
        //                matrix[row][col]== matrix[row+1][col] &&
        //                matrix[row][col]== matrix[row+1][col +1])
        //            {
        //                count++;
        //            }

        //        }

        //    }

        //    return count;

        //}



    }
}
