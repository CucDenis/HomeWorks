using System;
using System.IO;
using System.Collections;

namespace FolderSizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the name of the folder where you have the file you want to know the size: ");
            string path = Console.ReadLine();

            DirectoryInfo di = new DirectoryInfo(path);

            foreach (var fi in di.GetFiles()) {
                Console.WriteLine("File {0} with size of {1} bytes",fi.Name,fi.Length);
            }
        }
    }
}
