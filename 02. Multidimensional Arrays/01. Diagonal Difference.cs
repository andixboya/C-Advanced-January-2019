using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P00Lab
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            matrix= FillInMatrixTwo(size, matrix);


            int first= GetPrimaryDiagonalSum(matrix);
            int second = GetSecondaryDiagonalSum(matrix);

            int result = Math.Abs(first - second);

            Console.WriteLine(result);

            

        }

        private static int GetSecondaryDiagonalSum(int[,] matrix)
        {

            int rowTopRight = 0;
            int colTopRight = matrix.GetLength(1)-1;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {



                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    if (rowTopRight==row && colTopRight==col)
                    {
                        sum += matrix[row, col];
                    }

                }

                rowTopRight ++;
                colTopRight--;

                if (rowTopRight>=matrix.GetLength(0) || colTopRight<0 )
                {
                    break;
                }

            }

            return sum;

        }

        private static int GetPrimaryDiagonalSum(int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    if (row==col)
                    {
                        sum += matrix[row, col];
                        break;
                    }
                    
                }

            }

            return sum;

        }

        private static int[,] FillInMatrixTwo(int size, int[,] matrix)
        {
            for (int row = 0; row < size; row++)
            {

                int[] rowInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowInput[col];
                }

            }

            return matrix;
        }

        private static int[][] FillInMatrix(int size)
        {

            int rowMax = size;
            int colMax = size;

            int[][] matrix = new int[rowMax][];

            for (int row = 0; row < rowMax; row++)
            {
                int[] rowInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = rowInput;
            }


            return matrix;
        }

        private static bool ValidateIndexes(int[] indexes, int size)
        {
            int rowIndex = indexes[0];
            int colIndex = indexes[1];

            if (rowIndex < 0 || rowIndex >= size
                || colIndex < 0 || colIndex >= size)
            {
                Console.WriteLine("Invalid coordinates");
                return false;
            }

            return true;

        }

        private static void Print(int[][] matrix)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var row in matrix)
            {
                sb.AppendLine(string.Join(" ", row));
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static void PrintVTwo(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();

            int rowMax = matrix.GetLength(0);
            int colMax = matrix.GetLength(1);

            for (int row = 0; row < rowMax; row++)
            {

                for (int col = 0; col < colMax; col++)
                {

                    if (col == colMax - 1)
                    {
                        sb.AppendLine($"{matrix[row, col]}");
                    }

                    else
                    {
                        sb.Append($"{matrix[row, col]} ");
                    }

                }

            }


            Console.WriteLine(sb.ToString().TrimEnd());
        }




        
    }
}
