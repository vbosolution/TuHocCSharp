using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_240224_CountCharInString
{
    internal class Program
    {
        static char GetChar()
        {
            Console.Write("Input a char: ");
            char ch = (char)(Console.Read());
            return ch;
        }
        static int CharCount(char ch, string s)
        {
            int count = 0;
            for (int i = 0;i < s.Length;i++)
            {
                if (s[i] == ch)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string s = "This is the test string";
            Console.WriteLine(s);
            char ch = GetChar();
            Console.WriteLine("There're " + CharCount(ch, s) + " times of the char: '" + ch + "' in the test string");
            Console.ReadKey();
        }
    }
}
