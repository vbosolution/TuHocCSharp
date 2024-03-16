using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W07_ICompareableInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5.0);
            ComperableCircle[] circles = new ComperableCircle[4];
            circles[0] = new ComperableCircle(3.6);
            circles[1] = new ComperableCircle();
            circles[2] = new ComperableCircle(3.5, "indigo", false);
            circles[3] = new ComperableCircle(c);

            Console.WriteLine("Pre-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Array.Sort(circles);

            Console.WriteLine("After-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }
            Console.ReadKey();
        }
    }
}
