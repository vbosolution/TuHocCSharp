using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_Fan_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            fan1.Speed = Fan.FAST;
            fan1.Color = "yellow";
            fan1.Radius = 10;
            fan1.On = true;

            Fan fan2 = new Fan();
            fan2.Speed = Fan.MEDIUM;
            Console.WriteLine("Fan1");
            Console.WriteLine(fan1.ToString());
            Console.WriteLine("Fan2");
            Console.WriteLine(fan2.ToString());
            Console.ReadKey();
        }
    }
}
