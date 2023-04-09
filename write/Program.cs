using System;
using System.IO;

namespace write
{
    class Program
    {
        static void Main(string[] args)
        {            
            string filePath = @"/home/jaime/Desktop/ex.txt";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("This is another line added to the file.");
            }
        }
    }
}
