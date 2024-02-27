using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__240227_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle project.");
            Console.Write("Input rectangle's width: ");
            double w = Double.Parse(Console.ReadLine());
            Console.Write("Input rectangle's height: ");
            double h = Double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(w, h);
            Console.WriteLine(rect.Inspect());
            Console.WriteLine($"Area: {rect.Area()}");
            Console.WriteLine($"Perimeter: {rect.Perimeter()}");
            Console.ReadKey();
        }
    }
}

