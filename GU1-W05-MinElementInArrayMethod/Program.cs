using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W05_MinElementInArrayMethod
{
    internal class Program
    {
        public static int MinElement(int[] ar)
        {
            int min = ar[0];
            int index = 0;
            for(int i = 1; i < ar.Length; i++)
            {
                if (ar[i] < min)
                {
                    min = ar[i];
                    index = i;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            int[] ar = { 1, 12, 4, 7, 8, 1, 9, 6 };
            int index = MinElement(ar);
            Console.WriteLine($"Min element is {ar[index]} at index: {index}");
            Console.ReadKey();
        }
    }
}
