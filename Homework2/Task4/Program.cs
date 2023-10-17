namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fN = Console.ReadLine();
            var lN = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();

            Console.WriteLine("Hello, I'm {0} {1}, I'm {2} years old and I live in {3}", fN, lN, age, town);

            Console.ReadKey();
        }
    }
}