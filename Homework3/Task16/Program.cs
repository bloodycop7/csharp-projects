using System.Linq;

namespace Task16
{
    internal class Program
    {
        // Напишете програма, която приема две числа и извежда по-голямото от тях без да използва оператори за сравнение

        // Math.Sign
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double fN = double.Parse(Console.ReadLine());

            Console.Write("Input second number: ");
            double sN = double.Parse(Console.ReadLine());

            double[] numbers = {fN, sN}; // Outsmart :D

            Console.WriteLine(numbers.Max());

            Console.ReadKey();
        }
    }
}
