using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W04_InsertAValueAtIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 10, 4, 6, 7, 8, 0, 0, 0, 0, 0 };
            Console.WriteLine("Array");
            foreach (int i in ar)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("Input the insert number: ");
            int insert = Int32.Parse(Console.ReadLine());

            Console.Write("Input the index of insertion: ");
            int index = Int32.Parse(Console.ReadLine());

            for (int i = ar.Length - 1; i > index; i--)
            {
                ar[i] = ar[i - 1];
            }
            ar[index] = insert;

            Console.WriteLine("Array after the insertion");
            foreach (int i in ar)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
