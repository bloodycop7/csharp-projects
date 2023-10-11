namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input celsius: ");

            var c = double.Parse(Console.ReadLine());
            double f = (c * 9/5) + 32;

            Console.WriteLine(f);
        }
    }
}