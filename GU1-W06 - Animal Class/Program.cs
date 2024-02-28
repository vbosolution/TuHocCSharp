using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06___Animal_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("20kg", "1.5", "kitty");
            cat.PrintInfo();
            cat.Shout();

            Dog dog = new Dog("30kg", "1.5", "kiki");
            dog.PrintInfo();
            dog.Shout();
            Console.ReadKey();

        }
    }
}
