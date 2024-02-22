using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240222___MineMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] map = {
                {"*", ".", ".", "*"},
                {".", "*", ".", "."},
                {".", "*", "*", "."},
                {"*", ".", ".", "."}
            };
            int rows = map.GetLength(0);
            int columns = map.GetLength(1);

            string[,] result = new string[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < map.GetLength(0); column++)
                {
                    if (map[row, column] == "*")
                    {
                        result[row, column] = "*";
                    }
                    else
                    {
                        int[,] neighbours = {
                        {row - 1, column - 1}, {row - 1, column}, {row - 1, column + 1},
                        {row, column - 1}, {row, column + 1},
                        {row + 1, column - 1}, {row + 1, column}, {row + 1, column + 1},};

                        int minesCount = 0;
                        int length = neighbours.GetLength(0);
                        for (int i = 0; i < length; i++)
                        {
                            int xx = neighbours[i, 1];
                            int yy = neighbours[i, 0];

                            if (xx < 0 || xx == columns || yy < 0 || yy == rows)
                            {
                                continue;
                            }

                            if (map[yy, xx] == "*")
                            {
                                minesCount++;
                            }
                        }

                        result[row, column] = minesCount.ToString();
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine("\n");
                for (int column = 0; column < columns; column++)
                {
                    Console.Write(result[row, column] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
