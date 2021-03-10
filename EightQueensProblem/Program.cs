using System;

namespace EightQueensProblem
{
    class Program
    {
        const int boardSize = 8;
        static int foundTotal = 0;

        static void Main(string[] args)
        {
            int[] queenPositions = new int[boardSize];
            FindNext(queenPositions, 0);
        }

        static void FindNext(int[] queenPositions, int row)
        {
            for (int i = 0; i < boardSize; i++)
            {
                if (CheckPosition(queenPositions, row, i))
                {
                    queenPositions[row] = i;
                    if (row + 1 < boardSize)
                    {
                        FindNext(queenPositions, row + 1);
                    }
                    else
                    {
                        foundTotal++;
                        PrintPosition(queenPositions);
                    }
                }
            }
        }

        static bool CheckPosition(int[] queenPositions, int row, int column )
        {
            for (int i = 0; i < row; i++)
            {
                if ((column == queenPositions[i]) || (column == queenPositions[i] + (row - i)) || (column == queenPositions[i] - (row - i)))
                {
                    return false;
                }
            }
            return true;
        }

        static void PrintPosition(int[] queenPositions)
        {
            Console.WriteLine("Result #" + foundTotal);
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (j == queenPositions[i])
                    {
                        Console.Write('Q');
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
