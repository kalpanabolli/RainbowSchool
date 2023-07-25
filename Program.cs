using System;
using System.IO;

namespace ConAppStudentData
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = "D:\\Simply Learn\\Student Data.txt";

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("The student data file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }

            Console.ReadLine(); 
        }
    }
}