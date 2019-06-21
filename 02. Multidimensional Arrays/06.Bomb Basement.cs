using System;
using System.Linq;
using System.Text;

namespace P06BombBasement
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
            int colMax = size[1];

            int[][] matrix = new int[rowMax][];
            matrix = FillUpField(rowMax, colMax, matrix);


            int[] shootingCoordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int targetRow = shootingCoordinates[0];
            int targetCol = shootingCoordinates[1];
            int radius = shootingCoordinates[2];

            ShootTarget(targetRow, targetCol, radius, matrix);            
            FallingDown(matrix);
            Print(matrix);

        }

        private static void Print(int[][] matrix)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var row in matrix)
            {
                sb.AppendLine(string.Join("", row));
            }

            Console.WriteLine(sb.ToString().TrimEnd());

        }

        private static void FallingDown(int[][] matrix)
        {

            int rowMax = matrix.GetLength(0);
            int colMax = matrix[0].Length;


            for (int col = 0; col < colMax; col++)
            {
                for (int row = 0; row < rowMax; row++)
                {
                    if (matrix[row][col] == 1)
                    {
                        continue;
                    }

                    int current = matrix[row][col]; //this is the current , which is 0, the ones that are 1 , are skipped , via continue !

                    for (int secondRow = row + 1; secondRow < rowMax; secondRow++)
                    {
                        // we search for the next 0 ,  if we find it..., we break the loop, so that we don`t iterate without purpose
                        if (matrix[secondRow][col] == 1)
                        {
                            matrix[row][col] = matrix[secondRow][col];
                            matrix[secondRow][col] = current;
                            break;

                        }

                    }
                }

            }


            //нулите отиват към... края , демек... или единиците към началото
            // боравя с 1-ците, защото те се приближават към началото? 

        }

        private static void ShootTarget(int targetRow, int targetCol, int radius, int[][] matrix)
        {
            int rowMax = matrix.GetLength(0);
            int colMax = matrix[0].Length;

            for (int row = 0; row < rowMax; row++)
            {

                for (int col = 0; col < colMax; col++)
                {

                    if ((col - targetCol) * (col - targetCol) +
                        (row - targetRow) * (row - targetRow) <= radius * radius)
                    {

                        matrix[row][col] = 1;
                    }

                }


            }


        }

        private static int[][] FillUpField(int rowMax, int colMax, int[][] basement)
        {
            for (int row = 0; row < rowMax; row++)
            {
                basement[row] = new int[colMax];
            }

            return basement;
        }
    }
}
