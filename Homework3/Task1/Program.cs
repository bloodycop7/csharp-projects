namespace Task1
{
    internal class Program
    {

        // Напишете програма, която чете две числа и извежда техния сбор.
        static void Main(string[] args)
        {
            Console.Write("Input your first number: ");
            double fN = double.Parse(Console.ReadLine());

            Console.Write("Input your second number: ");
            double sN = double.Parse(Console.ReadLine());

            Console.WriteLine("Total: {0}", (fN + sN));

            Console.ReadKey();
        }
    }
}
