namespace Task6
{
    internal class Program
    {

        // Създайте програма, която изисква от потребителя да въведе три числа и извежда тяхната средна стойност (средно аритметично)
        static void Main(string[] args)
        {
            Console.Write("Input your first number: ");
            double fN = double.Parse(Console.ReadLine());

            Console.Write("Input your second number: ");
            double sN = double.Parse(Console.ReadLine());

            Console.Write("Input your third number: ");
            double tN = double.Parse(Console.ReadLine());

            Console.WriteLine("Answer: {0}", (fN + sN + tN) / 3);
            Console.ReadKey();
        }
    }
}
