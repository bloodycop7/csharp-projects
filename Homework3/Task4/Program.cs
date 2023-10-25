namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Input width: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Answer: {0}", (length * 2) + (width * 2));

            Console.ReadKey();
        }
    }
}
