using System;
using System.IO;
using System.Text;

namespace RandomThing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateFile("Important", "CSharp is Cool");
            ReadFile("D:\\csharp-projects\\RandomThing\\RandomThing\\bin\\Debug\\net6.0\\Important.txt");
        }

        static void CreateFile(string name, string contents)
        {
            StreamWriter file = new StreamWriter(name + ".txt");
            file.WriteLine(contents);
            file.Close();
        }

        static void ReadFile(string path)
        {
            StreamReader file = new StreamReader(path);
            Console.WriteLine(file.ReadToEnd());
            file.Close();
        }
    }
}