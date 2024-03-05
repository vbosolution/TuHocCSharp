using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W08_IndexOutOfRangeException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> chars = new List<char>();
                chars.InsertRange(0, new char[] { 'A', 'B', 'C', 'D' });
                Console.Write("Input an index: ");
                int index = Int32.Parse(Console.ReadLine());
                int value = chars[index];
                Console.WriteLine(value);
            }
            catch (IndexOutOfRangeException e) 
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();

        }
    }
}
