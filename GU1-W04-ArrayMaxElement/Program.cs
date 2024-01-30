using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W04_ArrayMaxElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            do
            {
                Console.Write("Enter array's size: ");
                size = int.Parse(Console.ReadLine());
                if (size >= 20)
                {
                    Console.WriteLine("Size must be under 20!");
                    Console.ReadKey();
                }
            } while (size >= 20);

            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the elemet at number " + (i + 1) + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }
            int max = a[0];
            int j = 0;
            for ( int i = 1; i < size; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    j = i;
                }
            }
            Console.WriteLine("Max value is element at " + j + ": " +  max);
            Console.ReadKey();
        }
    }
}
