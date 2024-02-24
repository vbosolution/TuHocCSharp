using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240222___Methods
{
    internal class Program
    {
        public static int CountEvenInArray(int[] arr)
        {
            int count = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //foreach(int i in a)
            //{
            //    Console.Write(i + "  ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("There're " + CountEvenInArray(a) + " even numbers.");

            //Console.SetCursorPosition(5, 5); // đặt vị trí của rắn hoặc mồi tại tọa độ (x, y)
            //Console.ForegroundColor = ConsoleColor.Green; // đặt màu cho rắn
            //Console.BackgroundColor = ConsoleColor.Red; // đặt màu cho mồi
            //Console.Write("O"); // vẽ rắn hoặc mồi bằng ký tự O

            //Console.ReadKey();
            int rows = 4;
            int start_row = 0;
            for (int i = start_row; i < rows + start_row; i++) {
                for (int j = 0; j <= i;  j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("0");
                }
            }

            start_row += 5;

            for (int i = start_row; i < rows + start_row; i++)
            {
                for (int j = i - start_row; j < rows; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
            }

            start_row += 5;

            for (int i = start_row; i < rows + start_row; i++)
            {
                for (int j = rows; j > i - start_row; j--)
                {
                    Console.SetCursorPosition(j, i);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
            }
            int x = 0;
            int y = 3;
            while (true)
            {
                Console.SetCursorPosition((int)x, (int)y);

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y > 0)
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < 30)
                        { 
                            y++; 
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 0)
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < 30)
                        {
                            x++;
                        }
                        break;

                }
            }
        }
        
    }
}
