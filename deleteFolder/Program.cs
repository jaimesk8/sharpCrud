using System;
using System.IO;

namespace deleteFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"/home/jaime/Desktop/teste";
            Directory.Delete(folderPath);
        }
    }
}
