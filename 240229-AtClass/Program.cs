using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240229_AtClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle Class");
            Circle circle = new Circle();
            Console.WriteLine(circle);
            circle = new Circle(3.5);
            Console.WriteLine(circle);
            Console.WriteLine();

            Console.WriteLine("Rectangle Class");
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);
            rectangle = new Rectangle(2.3, 5.8);
            Console.WriteLine(rectangle);
            Console.ReadKey();

        }
    }
}
