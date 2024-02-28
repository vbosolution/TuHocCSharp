using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_Static_Method
{
    public class Student
    {
        private int rollno;
        private string name;
        private static string college = "BBDIT";


        public Student(int r, string n)
        {
            rollno = r;
            name = n;
        }

        // Likes class methods vs instance methods in Ruby
        // static method is a class method, called by class#method

        public static void Change()
        {
            college = "CODEGYM";
        }

        // this is an instance method. called by the object#method

        public void Display()
        {
            Console.WriteLine(rollno + " " + name + " " + college);
        }
    }
}
