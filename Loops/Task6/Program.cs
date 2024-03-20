using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            if (numberCount < 1)
            {
                Console.WriteLine("[Error] Number must be above or equal to 1");
            }

            double firstNumbersSum = 0;
            double otherNums = 0;

            for (int i = 1; i <= numberCount; i++) {
                double sum1 = double.Parse(Console.ReadLine());
                double sum2 = double.Parse(Console.ReadLine());

                if ( i == 1 ) {
                    firstNumbersSum = sum1 + sum2;
                }
                else {
                    otherNums = sum1 + sum2;
                }
            }

            switch (Math.Abs(firstNumbersSum - otherNums)) {
                case 0:
                    Console.WriteLine($"Yes!");
                    break;
                default:
                    Console.WriteLine($"No! Diff = {Math.Abs(firstNumbersSum - otherNums)}");
                    break;
            }
        }
    }
}
