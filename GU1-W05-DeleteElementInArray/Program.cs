using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W05_DeleteElementInArray
{
    internal class Program
    {
        public static int[] DeleteElement(int[] array, int index)
        {
            for(int i = index;i<array.Length - 1;i++)
            {
                array[i] = array[i + 1];
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] ar = { 1, 12, 4, 7, 8, 1, 9, 6 };
            int index = 4;
            Console.WriteLine($"After delete at {index}:");
            for(int i = 0;i < ar.Length - 1; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
