using System;
using System.Linq;
using System.Text;

namespace P09Miner
{
    public class Program
    {


        private static int collectedCoals;
        private static int initialCoals;
        private static bool isGameOver = false;
        private static int playerCurrentRow;
        private static int playerCurrentCol;
        

        public static void Main(string[] args)
        {

            long size = long.Parse(Console.ReadLine());

            string[][] field = new string[size][];

            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            FillInField(field);


            for (int i = 0; i < commands.Length; i++)
            {
                string currentCommand = commands[i];

                MoveCharacter(currentCommand,field);

                if (isGameOver ||initialCoals-collectedCoals==0)
                {
                    break;
                }

            }

            if (isGameOver)
            {
                Console.WriteLine($"Game over! ({playerCurrentRow}, {playerCurrentCol})");
            }
            else if (initialCoals-collectedCoals==0)
            {
                Console.WriteLine($"You collected all coals! ({playerCurrentRow}, {playerCurrentCol})");
            }
            else
            {
                Console.WriteLine($"{initialCoals-collectedCoals} coals left. ({playerCurrentRow}, {playerCurrentCol})");
            }

        }

        private static void Print(string[][] field)
        {

            StringBuilder sb = new StringBuilder();

            foreach (var row in field)
            {
                sb.AppendLine($"{string.Join(" ", row)}");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static void MoveCharacter(string currentCommand, string[][] field)
        {

            
            if (!IsPlayerBlocked(currentCommand, field))
            {
                int newRowPos = playerCurrentRow;
                int newColPos = playerCurrentCol;

                switch (currentCommand)
                {
                    case "up":
                        newRowPos--;
                        break;
                    case "down":
                        newRowPos++;
                        break;
                    case "left":
                        newColPos--;
                        break;
                    case "right":
                        newColPos++;
                        break;
                }

                string itemToStepOn = field[newRowPos][newColPos];


                if (itemToStepOn=="*")
                {
                    field[playerCurrentRow][playerCurrentCol] = "*";
                    field[newRowPos][newColPos] = "s";

                }
                else if (itemToStepOn=="e")
                {
                    field[playerCurrentRow][playerCurrentCol] = "*";
                    field[newRowPos][newColPos] = "s";

                    isGameOver = true;

                }
                // in case of coal;
                else
                {
                    field[playerCurrentRow][playerCurrentCol] = "*";
                    field[newRowPos][newColPos] = "s";

                    collectedCoals++;
                }


                //after everything is set ,we set the new values to the current position!
                playerCurrentRow = newRowPos;
                playerCurrentCol = newColPos;

            }

        }

        private static bool IsPlayerBlocked(string currentCommand, string[][] field)
        {
            
            int fieldSize = field.GetLength(0);

            switch (currentCommand)
            {

                case "up":
                    if (playerCurrentRow-1<0)
                    {
                        return true;
                    }
                    break;

                case "down":
                    if (playerCurrentRow+1==fieldSize)
                    {
                        return true;
                    }

                    break;
                case "left":
                    if (playerCurrentCol-1<0)
                    {
                        return true;
                    }

                    break;

                case "right":
                    if (playerCurrentCol+1==fieldSize)
                    {
                        return true;
                    }

                    break;

            }


            return false;
            
        }

        private static void FindCurrentPosition(string[][] field)
        {
            int size = field.GetLength(0);


            bool BreakIt = false;

            for (int row = 0; row < size; row++)
            {

                for (int col = 0; col < size; col++)
                {

                    if (field[row][col]=="s")
                    {
                        playerCurrentRow = row;
                        playerCurrentCol = col;
                        BreakIt = true;
                        break;
                    }


                }

                if (BreakIt==true)
                {
                    break;
                }

            }


            
        }

        private static void FillInField(string[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {

                string[] currentRowSymbols = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                field[row] = currentRowSymbols;
            }


            foreach (var row in field)
            {
                initialCoals += row.Where(s => s == "c").Count();
            }

            FindCurrentPosition(field);
        }
    }
}
