namespace Task14
{
    internal class Program
    {
        // Напишете програма, която приема две цели числа и извежда частното и остатъка от делението на първото число на второто число.
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int fN = int.Parse(Console.ReadLine());

            Console.Write("Input second number: ");
            int sN = int.Parse(Console.ReadLine());

            int devided = fN / sN;

            int left = fN - devided;

            Console.WriteLine("Output: {0} | {1}", devided, left);

            Console.ReadKey();
        }
    }
}
