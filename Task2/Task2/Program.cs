using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            string correctString = "hello world";

            string inputLol = Console.ReadLine();

            DateTime start_time;
            TimeSpan elapsed;

            start_time = DateTime.Now;

            switch (inputLol)
            {
                case "hello world":
                    Console.WriteLine("Hello world");
                    elapsed = DateTime.Now - start_time;
                    Console.WriteLine(elapsed.TotalSeconds.ToString() + " sec");
                    break;
                default:
                    Console.WriteLine("Hello world");
                    elapsed = DateTime.Now - start_time;
                    Console.WriteLine(elapsed.TotalSeconds.ToString() + " sec");
                    break;
            }
        }
    }
}