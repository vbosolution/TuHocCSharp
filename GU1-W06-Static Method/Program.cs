﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_Static_Method
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Student.Change();

            Student s1 = new Student(1, "Hoang");
            Student s2 = new Student(2, "Khanh");
            Student s3 = new Student(3, "Nam");

            s1.Display();
            s2.Display();
            s3.Display();
            Console.ReadKey();
        }
    }
}
