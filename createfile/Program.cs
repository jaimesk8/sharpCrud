using System;
using System.IO;

namespace createfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/home/jaime/Desktop/ex.txt";
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("This is an example text file.");
            }   
        }
    }
}
