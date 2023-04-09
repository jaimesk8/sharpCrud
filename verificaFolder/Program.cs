using System;
using System.IO;

namespace verificaFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"/home/jaime/Desktop/redes2";
            bool folderExists = Directory.Exists(folderPath);
            Console.WriteLine(folderExists);
        }
    }
}
