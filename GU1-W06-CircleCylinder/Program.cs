using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_CircleCylinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle Class");
            Circle c = new Circle();
            Console.WriteLine(c);
            c = new Circle(2.0, "red");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.WriteLine("Cylinder Class");
            Cylinder cy = new Cylinder();
            Console.WriteLine(cy);
            cy = new Cylinder(2.0, 3.0, "red");
            Console.WriteLine(cy);

            Console.ReadKey();
        }
    }
}
