using System.Net.Security;
using System.Runtime.ExceptionServices;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(inputNumber < 2 ? 1 : 3)}");

            Console.ReadKey();
        }
    }
}
