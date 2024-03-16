using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W07_Colorable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle(3.5);
            shapes[1] = new Square(2.3);
            shapes[2] = new Rectangle(5.0, 3.0);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"- {shape.GetType().Name}: {shape.getArea()}");
                if (shape is Square square)
                {
                    square.HowToColor();
                }
            }
            Console.ReadKey();
        }
    }
}
