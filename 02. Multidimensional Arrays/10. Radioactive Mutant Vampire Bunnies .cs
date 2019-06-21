using System;
using System.Linq;
using System.Text;

namespace P10RadioActiveBunnies
{
    public class Program
    {

        private static int currentPlayerRow;
        private static int currentPlayerCol;
        private static char[][] maze;
        private static bool IsAlive = true;
        private static bool HasWon;

        private static int rowMax;
        private static int colMax;

        public static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            rowMax = size[0];
            colMax = size[1];

            maze = new char[rowMax][];

            FillInMaze(rowMax);

            char[] commands = Console.ReadLine().ToCharArray();

            for (int i = 0; i < commands.Length; i++)
            {

                char current = commands[i];

                PlayerMove(current);
                Infest();
                //TODO


                if (!IsAlive)
                {
                    break;
                }
                if (HasWon)
                {
                    break;
                }

            }

            Print();
            

            if (!IsAlive)
            {
                Console.WriteLine($"dead: {currentPlayerRow} {currentPlayerCol}");
            }
            else if (HasWon)
            {
                Console.WriteLine($"won: {currentPlayerRow} {currentPlayerCol}");
            }


        }

        private static void Print()
        {

            StringBuilder sb = new StringBuilder();

            foreach (var row in maze)
            {
                sb.AppendLine(string.Join("", row));
            }

            Console.WriteLine(sb.ToString().TrimEnd());

        }

        private static void Infest()
        {
            // here we mark for infection
            for (int row = 0; row < rowMax; row++)
            {

                for (int col = 0; col < colMax; col++)
                {

                    if (maze[row][col] == 'B')
                    {
                        int bunnyRow = row;
                        int bunnyCol = col;

                        MarkForInfection(row, col);

                    }


                }

            }

            //here we infect the marked spots.
            

            for (int row = 0; row < rowMax; row++)
            {

                for (int col = 0; col < colMax; col++)
                {
                    

                    if (maze[row][col] == 'I')
                    {
                        maze[row][col] = 'B';
                    }

                }

            }

        }

        private static void MarkForInfection(int row, int col)
        {
            for (int rowStart = row - 1; rowStart <= row + 1; rowStart++)
            {
                // infect the rows first
                if (rowStart>=0 && rowStart<rowMax)
                {
                    if (maze[rowStart][col] =='B')
                    {
                        continue;
                    }
                    if (maze[rowStart][col] == 'P')
                    {
                        IsAlive = false;
                    }

                    maze[rowStart][col] = 'I';

                }

            }


            //infect the other way
            for (int colStart = col-1; colStart <= col+1; colStart++)
            {
                if (colStart>=0 && colStart<colMax)
                {
                    if (maze[row][colStart]=='B')
                    {
                        continue;
                    }
                    if (maze[row][colStart] == 'P')
                    {
                        IsAlive = false;
                    }

                    maze[row][colStart] = 'I';

                }


            }


            //for (int colStart = col - 1; colStart <= col + 1; colStart++)
            //{
            //    // we check if the bunnies don`t hit the walls/edge
            //    if (rowStart >= 0 && rowStart < rowMax
            //        && colStart >= 0 && colStart < colMax)
            //    {

            //        if (maze[rowStart][colStart] == 'B')
            //        {
            //            continue;
            //        }

            //        //here he dies
            //        if (maze[rowStart][colStart]=='P')
            //        {
            //            IsAlive = false;
            //        }


            //        // we infect everything that is not the wall
            //        maze[rowStart][colStart] = 'I';
            //    }


            //}



        }

        private static void PlayerMove(char current)
        {
            // in case he wins
            HitsAWall(current);

            //if he has not won, we continue... (means we... didnt hit a wall
            if (!HasWon)
            {

                int newRowPos = currentPlayerRow;
                int newColPos = currentPlayerCol;

                switch (current)
                {
                    case 'U':
                        newRowPos--;
                        break;
                    case 'D':
                        newRowPos++;
                        break;
                    case 'L':
                        newColPos--;
                        break;
                    case 'R':
                        newColPos++;
                        break;
                }

                char itemToStepOn = maze[newRowPos][newColPos];

                if (itemToStepOn == 'B')
                {
                    maze[currentPlayerRow][currentPlayerCol] = '.';

                    //and he dies
                    IsAlive = false;

                }
                else if (itemToStepOn=='.') 

                {
                    maze[currentPlayerRow][currentPlayerCol] = '.';
                    maze[newRowPos][newColPos] = 'P';
                }
                


                // big mistake!!!! TODO
                currentPlayerRow = newRowPos;
                currentPlayerCol = newColPos;

            }

        }

        private static void HitsAWall(char current)
        {

            colMax = maze[0].Length;

            switch (current)
            {
                case 'U':
                    if (currentPlayerRow - 1 < 0)
                    {
                        HasWon = true;
                    }
                    break;

                case 'D':
                    if (currentPlayerRow + 1 == maze.GetLength(0))
                    {
                        HasWon = true;
                    }
                    break;

                case 'L':
                    if (currentPlayerCol - 1 < 0)
                    {
                        HasWon = true;
                    }

                    break;
                case 'R':
                    if (currentPlayerCol + 1 == colMax)
                    {
                        HasWon = true;
                    }
                    break;

            }

            if (HasWon == true) 
            {
                maze[currentPlayerRow][currentPlayerCol] = '.';
            }


        }

        private static void FillInMaze(int maxRow)
        {
            for (int row = 0; row < maxRow; row++)
            {

                string inputRow = Console.ReadLine();

                maze[row] = inputRow.ToCharArray();

            }

            FindPlayer();

        }

        private static void FindPlayer()
        {

            bool breakIt = false;

            for (int row = 0; row < rowMax; row++)
            {

                for (int col = 0; col < colMax; col++)
                {
                    if (maze[row][col] == 'P')
                    {
                        currentPlayerRow = row;
                        currentPlayerCol = col;
                        breakIt = true;
                        break;
                    }
                }

                if (breakIt == true)
                {
                    break;
                }

            }


        }
    }
}
