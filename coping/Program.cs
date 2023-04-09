using System;
using System.IO; 

namespace coping
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"/home/jaime/Desktop/Aula1deProjeto";
            string destinationFilePath = @"/home/jaime/Desktop/projeto_programçãoAvançada/Aula1deProjeto";
            File.Copy(sourceFilePath, destinationFilePath);         
        }
    }
}
