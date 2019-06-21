using System;
using System.Linq;

namespace P07KnightGame
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

           

            int size = int.Parse(Console.ReadLine());


            char[][] matrix = new char[size][];
            FillInMatrix(size, matrix);


            int countOfRemovedKnights = 0;

            while (true)
            {


                int maxAttacks = -1;
                int rowMax = -1;
                int colMax = -1;







                for (int row = 0; row < size; row++)
                {

                    for (int col = 0; col < size; col++)
                    {

                        if (matrix[row][col] == 'K')
                        {

                            int currentCountOfAttacks = GetCountOfAttacks(row, col, matrix);

                            if (currentCountOfAttacks > maxAttacks)
                            {
                                maxAttacks = currentCountOfAttacks;
                                rowMax = row;
                                colMax = col;
                            }
                        }

                    }

                }

                if (maxAttacks>0)
                {
                    matrix[rowMax][colMax] = '0';
                    countOfRemovedKnights++;
                }
                else
                {
                    break;
                }


            }
             
            Console.WriteLine(countOfRemovedKnights);

        }

        private static int GetCountOfAttacks(int row, int col, char[][] matrix)
        {

            int countOfAttacks = 0;

            int size = matrix.GetLength(0);


            if (ValidateIndexes(row-2,col-1,size) && matrix[row-2][col-1]=='K')
            {
                countOfAttacks++;
            }
            if (ValidateIndexes(row - 2, col + 1, size) && matrix[row - 2][col + 1] == 'K')
            {
                countOfAttacks++;
            }
            if (ValidateIndexes(row + 2, col - 1, size) && matrix[row + 2][col - 1] == 'K')
            {
                countOfAttacks++;
            }
            if (ValidateIndexes(row + 2, col + 1, size) && matrix[row +2][col + 1] == 'K')
            {
                countOfAttacks++;
            }
            if (ValidateIndexes(row +1, col + 2, size) && matrix[row +1][col + 2] == 'K')
            {
                countOfAttacks++;
            }
            if (ValidateIndexes(row + 1, col -2, size) && matrix[row + 1][col - 2] == 'K')
            {
                countOfAttacks++;
            }
            if (ValidateIndexes(row - 1, col + 2, size) && matrix[row - 1][col + 2] == 'K')
            {
                countOfAttacks++;
            }
            if (ValidateIndexes(row - 1, col - 2, size) && matrix[row - 1][col - 2] == 'K')
            {
                countOfAttacks++;
            }


            return countOfAttacks;

        }

        private static bool ValidateIndexes(int row, int col, int size)
        {
            return 
                row >= 0 &&
                row < size &&
                col >= 0 &&
                col < size;

        }

        private static void FillInMatrix(int size, char[][] matrix)
        {
            for (int row = 0; row < size; row++)
            {

                char[] rowChars = Console.ReadLine()
                    .ToCharArray();

                matrix[row] = rowChars;

            }
        }
    }
}
