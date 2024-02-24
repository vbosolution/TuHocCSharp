using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    internal class Program
    {
        static void DrawBoard(int maxWidth, int maxHeight)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            maxHeight += 2;
            maxWidth += 2;
            for (int i = 0; i < maxHeight; i++)
            {
                if (i == 0 || i == maxHeight - 1)
                {
                    for (int j = 0; j < maxWidth; j++)
                    {
                        Console.SetCursorPosition(j + 1, i + 1);
                        Console.Write(" ");
                    }
                    
                } else
                {
                    Console.SetCursorPosition(1, i + 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(maxWidth, i + 1);
                    Console.Write(" ");
                }
            }
        }
        static void DrawFrog(int x, int y)
        {
            Console.SetCursorPosition((int)x, (int)y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("x");
        }
        static void DrawSnake(int x, int y, bool actived)
        {
            Console.SetCursorPosition((int)x, (int)y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            if (actived)
            {
                Console.Write("o");
            }
            else
            {
                Console.Write(" ");
            }
        }
        static void ShowScore(int score, int height)
        {
            Console.SetCursorPosition(1, height + 3);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write($"Score: {score}");
        }
        static bool ShowGameOver(int height)
        {
            Console.SetCursorPosition(1, height + 3);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Game Over! - Continue ?(Y/N): ");
            char ch = (char)(Console.Read());
            while (Console.In.Peek() != -1) Console.In.Read();
            bool wantToContinue = (ch == 'n' || ch == 'N');
            return wantToContinue;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int boardWidth = 40;
            int boardHeight = 20;
            DrawBoard(boardWidth, boardHeight);

            bool frogShown = false;

            int x = (int)(boardWidth / 2);
            int y = (int)(boardHeight / 2);

            int frogX = rand.Next(2, boardWidth);
            int frogY = rand.Next(2, boardHeight);

            int score = 0;
            while (true)
            {
                ShowScore(score, boardHeight);

                if (!frogShown)
                {
                    do
                    {
                        frogX = rand.Next(2, boardWidth);
                        frogY = rand.Next(2, boardHeight);
                    } while (frogX != x && frogY != y);
                    frogShown = true;
                }
                DrawFrog(frogX, frogY);
                DrawSnake(x, y, true);
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                bool killed = false;
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y > 2)
                        {
                            DrawSnake(x, y, false);
                            y--;
                        } else
                        {
                            killed = true;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < boardHeight)
                        {
                            DrawSnake(x, y, false);
                            y++;
                        }
                        else
                        {
                            killed = true;
                        }

                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 2)
                        {
                            DrawSnake(x, y, false);
                            x--;
                        }
                        else
                        {
                            killed = true;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < boardWidth)
                        {
                            DrawSnake(x, y, false);
                            x++;
                        }
                        else
                        {
                            killed = true;
                        }
                        break;

                }
                if (frogX == x && frogY == y)
                {
                    score++;
                    frogShown = false;
                }

                if (killed)
                {
                    if (ShowGameOver(boardHeight))
                    {
                        break;
                    } else
                    {
                        DrawBoard(boardWidth, boardHeight);
                        x = (int)(boardWidth / 2);
                        y = (int)(boardHeight / 2);
                        score = 0;
                        frogShown = false;
                    }
                }
            }
        }
    }
}
