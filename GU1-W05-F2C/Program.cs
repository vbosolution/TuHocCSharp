using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W05_F2C
{
    internal class Program
    {
        public static double C2F(double c)
        {
            double f = (9.0 / 5) * c + 32;
            return f;
        }

        public static double F2C(double f)
        {
            double c = (5.0 / 9) * (f - 32);
            return c;
        }
        static void Main(string[] args)
        {
            double f;
            double c;
            int choice;

            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter fahrenheit: ");
                        f = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Fahrenheit to Celsius: " + F2C(f));
                        break;
                    case 2:
                        Console.WriteLine("Enter Celsius: ");
                        c = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Celsius to Fahrenheit: " + C2F(c));
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);
        }
    }
}
