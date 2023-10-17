namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Area = ");
            Console.WriteLine(area);

            Console.ReadKey();
        }
    }
}