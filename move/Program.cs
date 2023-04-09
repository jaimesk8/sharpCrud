using System;
using System.IO;

namespace move
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"/home/jaime/Desktop/home";
            string destinationFilePath = @"/home/jaime/Desktop/shared/home";
            File.Move(sourceFilePath, destinationFilePath);                                             
        }
    }
}
