namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inches = double.Parse(Console.ReadLine());
            var cm = inches * 2.54;

            Console.Write("CM = ");
            Console.WriteLine(cm);
        }
    }
}