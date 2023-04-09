using System;
using System.IO;

namespace delete
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/home/jaime/Desktop/ex.txt";
            File.Delete(filePath);
        }
    }
}
