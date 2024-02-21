namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = {"banana", "apple", "kiwi", "cherry", "lemon", "grapes"};
            string[] vegetables = {"tomato", "cucumber", "pepper", "carrot"};

            string product = Console.ReadLine().ToLower();

            if ( fruits.Contains(product) )
            {
                Console.WriteLine("fruit");
            }
            else if ( vegetables.Contains(product) )
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
