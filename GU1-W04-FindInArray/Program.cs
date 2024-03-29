﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W04_FindInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { 
                "Christian", 
                "Michael", 
                "Camila", 
                "Sienna", 
                "Tanya",
                "Connor", 
                "Zachariah", 
                "Mallory", 
                "Zoe", 
                "Emily" 
            };
            Console.Write("Enter a name’s student: ");
            string input_name = Console.ReadLine();
            //bool isExist = false;
            //for (int i = 0; i < students.Length; i++)
            //{
            //    if (students[i] == input_name)
            //    {
            //        Console.WriteLine("Position of the students in the list " + input_name + " is: " + (i + 1));
            //        isExist = true;
            //        break;
            //    }
            //}
            //if (!isExist)
            //{
            //    Console.WriteLine("Not found" + input_name + " in the list.");
            //}

            int index = Array.IndexOf(students, input_name);
            if (index == -1)
            {
                Console.WriteLine("Not found" + input_name + " in the list.");
            } else
            {
                Console.WriteLine("Position of the students in the list " + input_name + " is: " + index);
            }

            Console.Write("Press any key...");
            Console.ReadKey();
        }
    }
}
