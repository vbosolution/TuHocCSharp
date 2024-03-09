using System;
using System.IO;

namespace GU1_W08_SumNumberInFile
{
    internal class Program
    {
        class ReadTextFileExample
        {

            public void ReadTextFile(string filePath)
            {
                try
                {
                    FileInfo file = new FileInfo(filePath);
                    if (!file.Exists)
                    {
                        throw new FileNotFoundException();
                    }

                    StreamReader reader = new StreamReader(filePath);
                    
                    string line = "";
                    int sum = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        sum += Int32.Parse(line);
                    }
                        
                    Console.WriteLine("Total: " + sum);
                    Console.ReadKey();
                    
                }
                catch (Exception e) 
                {
                    Console.Error.WriteLine("Error: " + e.Message);
                }
            }
            public void WriteTextFile(string filePath)
            {
                try
                {
                    
                    FileInfo file = new FileInfo(filePath);
                    if (!file.Exists)
                    {
                        
                        StreamWriter writer = new StreamWriter(filePath);
                        Console.WriteLine("Enter text lines (enter an empty line to finish):");

                        string line;
                        while ((line = Console.ReadLine()) != "") 
                        {
                            writer.WriteLine(line); 
                        }

                        Console.WriteLine("Text has been written to the file.");
                        Console.ReadKey();
                    } else
                    {
                        Console.WriteLine("Error: File already exist");
                    }


                }
                catch (Exception e) 
                {
                    Console.WriteLine("Error: " + e.Message);
                    Console.ReadKey();
                }
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Please input file path");
            //string path = Console.ReadLine();
            //Console.WriteLine("File path: " + path);
            //ReadTextFileExample example = new ReadTextFileExample();
            //example.ReadTextFile(path); 

            Console.WriteLine("Please input file path:");
            string path = Console.ReadLine();
            ReadTextFileExample example = new ReadTextFileExample();
            example.WriteTextFile(path); 
        }
    }
}
