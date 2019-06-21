using System;
using System.Linq;
using System.Text;

namespace P04MatrixShuffling
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

            string[][] matrix = new string[rowMax][];
            matrix = FillUpMatrix(rowMax, matrix);

            string input = Console.ReadLine();

            while (input != "END")
            {

                string[] partitions = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (partitions.Length == 5 &&
                    partitions[0] == "swap")
                {
                    int rowX = int.Parse(partitions[1]);
                    int colX = int.Parse(partitions[2]);
                    int rowY = int.Parse(partitions[3]);
                    int colY = int.Parse(partitions[4]);


                    if (ValidateIndexes(rowY, colY, matrix) == false ||
                        ValidateIndexes(rowX, colX, matrix) == false)
                    {
                        input = Console.ReadLine();
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    var tempVar = matrix[rowX][colX];
                    matrix[rowX][colX] = matrix[rowY][colY];
                    matrix[rowY][colY] = tempVar;

                    Print(matrix);
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }


        }

        private static void Print(string[][] matrix)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var row in matrix)
            {
                sb.AppendLine(string.Join(" ", row));
            }

            Console.WriteLine(sb.ToString().TrimEnd());

        }

        private static bool ValidateIndexes(int rowX, int colX, string[][] matrix)
        {
            int maxRow = matrix.GetLength(0);
            int maxCol = matrix[0].Length;

            if (0 > rowX ||
                rowX >= maxRow ||
                0 > colX ||
                colX >= maxCol)
            {
                return false;
            }

            return true;

        }

        private static string[][] FillUpMatrix(int rowMax, string[][] matrix)
        {
            for (int row = 0; row < rowMax; row++)
            {
                string[] rowInput = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                matrix[row] = rowInput;
            }

            return matrix;
        }
    }
}
