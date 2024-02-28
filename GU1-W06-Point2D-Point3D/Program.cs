using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_Point2D_Point3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Point2D Class");
            Point2D p = new Point2D();
            p.SetX(0);
            p.SetY(5);
            Console.WriteLine(p);
            p.SetXY(5.0f, 8.0f);
            Console.WriteLine(p);
            Console.WriteLine();

            p = new Point2D(10.0f, 10.0f);
            Console.WriteLine(p);

            Console.WriteLine($"Point coordinates: x = {p.GetX()}; y = {p.GetY()}\nxy = {p.GetXY()[0]} ; {p.GetXY()[1]}");
            Console.WriteLine();

            Console.WriteLine("Point3D Class");
            Point3D pt = new Point3D();
            pt.SetX(0);
            pt.SetY(5);
            pt.SetZ(5.5f);
            Console.WriteLine(pt);
            pt.SetXYZ(5.0f, 8.0f, 4.8f);
            Console.WriteLine(pt);
            Console.WriteLine();

            pt = new Point3D(10.0f, 10.0f, 4.8f);
            Console.WriteLine(pt);

            Console.WriteLine($"Point coordinates: x = {pt.GetX()}; y = {pt.GetY()}; z = {pt.GetZ()}\nxyz = {pt.GetXYZ()[0]} ; {pt.GetXYZ()[1]}; {pt.GetXYZ()[2]}");
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
