using System;
using System.IO;

namespace read
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/home/jaime/Desktop/hello.asm";
            using (StreamReader sr = File.OpenText(filePath))
            {
                string fileContents = sr.ReadToEnd();
                Console.WriteLine(fileContents);
            }
        }
    }
}

/*output 
section         .text                   ; declare the .text section
global          _start                  ; has to be declared for the linker(ld)
_start:
    mov edx, len ;moving memory
    mov ecx, msg
    mov ebx, 1
    mov eax, 4
    int 0x80 ; int for interrupt
    mov eax, 1
    int 0x80

section         .data
    msg         db "this is my first project in assembly", 0xa   ; declare the message
    len         equ $ -msg               ; assing the length of the message to len
    */
