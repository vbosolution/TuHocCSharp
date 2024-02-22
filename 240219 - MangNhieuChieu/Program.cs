using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240219___MangNhieuChieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = {
                { 1, 2, 3, 4, 5, 6, 7 },
                { 1, 12, 3, 4, 5, 6, 7},
                { 1, 2, 33, 4, 5, 96, 7},
                { 1, 24, 3, 4, 5, 6, 7},
                { 1, 2, 3, 4, 15, 6, 7}
            };
            Console.WriteLine("Matrix:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            int max = a[0, 0];
            int ii = 0, jj = 0;
            for (int i=0; i<a.GetLength(0); i++)
            {
                for (int j=0; j<a.GetLength(1); j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                        ii = i;
                        jj = j;
                    }
                    if (i == j)
                    {
                        sum += a[i, j];
                    }
                }
            }
            Console.WriteLine("Sum all elements on the main diagonal : " + sum);
            Console.WriteLine("Max elements: " + max + " found at: (" + ii + "," + jj + ")");
            Console.ReadKey();
        }
    }
}
