namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            var fN = Console.ReadLine();

            Console.Write("What is your last name? ");
            var lN = Console.ReadLine();

            Console.Write("What is your age? ");
            var age = int.Parse(Console.ReadLine());

            Console.Write("What is the name of your town? ");
            var town = Console.ReadLine();

            Console.WriteLine("Hello, I'm {0} {1}, I'm {2} years old and I live in {3}", fN, lN, age, town);

            Console.ReadKey();
        }
    }
}