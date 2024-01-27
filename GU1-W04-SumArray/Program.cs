using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W04_SumArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] numbers = new int[5];
                numbers[0] = 2;
                numbers[1] = 5;
                numbers[2] = 9;
                numbers[3] = 6;
                numbers[4] = 7;

                Console.WriteLine("Phan tu dau tien: " + numbers[0]);
                Console.WriteLine("Phan tu thu 3: " + numbers[2]);
                Console.WriteLine("Phan tu thu 4: " + numbers[3]);

                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine("Tong cac gia tri cua mang: " + sum);
                Console.ReadKey();
            }
        }
    }
}
