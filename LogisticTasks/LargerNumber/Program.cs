namespace LargerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Greater Number: {(a > b ? a : b)}");
        }
    }
}
