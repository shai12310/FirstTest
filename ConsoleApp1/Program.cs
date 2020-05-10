using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"C:\Users\Shai\Desktop\testFile.txt", "hello #3");
        }
    }
}
