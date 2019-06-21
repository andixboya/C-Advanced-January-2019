using System;
using System.Linq;
using System.Text;

namespace P08Bombs
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rowMax = size[0];
            int colMax = size[0];

            int[][] matrix = new int[rowMax][];

            FillInMatrix(rowMax, matrix);

            string[] coordinates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < coordinates.Length; i++)
            {
                string[] currentCoordinates = coordinates[i].Split(",");
                int currentRow = int.Parse(currentCoordinates[0]);
                int currentCol = int.Parse(currentCoordinates[1]);

                int currentPower = matrix[currentRow][currentCol];

                if (currentRow< 0 || currentRow>= rowMax ||
                        currentCol< 0 || currentCol>= colMax ||
                        currentPower<=0)
                {
                    continue;
                }

                ExplodeNumber(currentRow, currentCol, matrix, currentPower);

            }

            int numberOfAliveCells = 0;
            int sumOfAliveCells = 0;

            StringBuilder sb = new StringBuilder();


            foreach (var row in matrix)
            {
                numberOfAliveCells += row.Where(c => c > 0).Count();
                sumOfAliveCells += row.Where(c=> c>0).Sum();

                sb.AppendLine(string.Join(" ",row));    

            }

            Console.WriteLine($"Alive cells: {numberOfAliveCells}");
            Console.WriteLine($"Sum: {sumOfAliveCells}");
            Console.WriteLine(sb.ToString().TrimEnd());


        }

        private static void ExplodeNumber(int currentRow, int currentCol, int[][] matrix, int explodingPower)
        {

            int maxRowMatrix = matrix.GetLength(0);
            int maxColMatrix = matrix[0].GetLength(0);// not sure if this is valid

            for (int row = currentRow- 1; row <= currentRow+1; row++)
            {

                for (int col = currentCol-1; col <= currentCol+1; col++)
                {

                    if (row<0 || row>=maxRowMatrix ||
                        col<0 || col>=maxColMatrix  ||
                        matrix[row][col]<=0)
                    {
                        continue;
                    }

                    matrix[row][col] -= explodingPower;

                }


            }

        }

        private static void ValidateIndexes(int row, int col, int[][] matrix)
        {

            
        }

        private static void FillInMatrix(int rowMax, int[][] matrix)
        {
            for (int row = 0; row < rowMax; row++)
            {
                int[] rowInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = rowInput;

            }
        }
    }
}
