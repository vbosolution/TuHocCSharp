using System;
using System.Linq;


namespace GU1_W06_StopWatch_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100000];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100000);
            }


            StopWatch stopWatch = new StopWatch();
            stopWatch.Start();
            SelectionSort(array);
            stopWatch.Stop();

            //Console.WriteLine($"After sort: {String.Join(" ", array.Select(x => x.ToString()))}");

            Console.WriteLine($"Total time of the Selection Sort algorithm for a 100K elements array: {stopWatch.GetElapsedTime()} milliseconds");
            Console.ReadKey();
        }

        static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }
    }
}
